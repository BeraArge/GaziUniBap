using AutoMapper;
using BusinessLogicLayer.Abstracts;
using Core.Enums;
using Core.Paging;
using Core.ResultType;
using DataAccessLayer.EntityFramework.Abstracts;
using DataAccessLayer.EntityFramework.Concretes;
using DataTransferObject.CozumlemeSoruUser;
using DataTransferObject.Home;
using DataTransferObject.Soru;
using DataTransferObject.SoruUser;
using DataTransferObject.SoruUser.Excel;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concretes
{
    public class SoruUserBL : ISoruUserBL
    {
        private readonly ISoruUserRepository _soruUserRepository;
        private readonly IUserRepository _userRepository;
        private readonly ICozumlemeSoruUserRepository _cozumlemeSoruUserRepository;
        private readonly ISoruRepository _soruRepository;
        private readonly IMapper _mapper;

        public SoruUserBL(ISoruUserRepository soruUserRepository, IMapper mapper, ISoruRepository soruRepository, ICozumlemeSoruUserRepository cozumlemeSoruUserRepository, IUserRepository userRepository)
        {
            _soruUserRepository = soruUserRepository;
            _mapper = mapper;
            _soruRepository = soruRepository;
            _cozumlemeSoruUserRepository = cozumlemeSoruUserRepository;
            _userRepository = userRepository;
        }

        private void CheckAndCompleteSimulation(int userId)
        {
            var totalQuestionCount = _soruRepository.GetAsList(x => true).Count;

            var userAnswers = _soruUserRepository.GetAsList(x => x.UserId == userId);

            var userAnsweredQuestionCount = userAnswers
                .Select(x => x.SoruId)
                .Distinct()
                .Count();

            var totalScore = userAnswers.Sum(x => x.Puan ?? 0);

            var user = _userRepository.Get(x => x.Id == userId);

            if (user == null)
                return;

            user.ToplamPuan = totalScore;

            if (totalQuestionCount > 0 && userAnsweredQuestionCount >= totalQuestionCount)
            {
                user.SimulasyonTamamlandiMi = true;
            }

            user.UpdatedAt = DateTime.Now;

            _userRepository.Update(user);
        }
        public Result<List<SoruUserDTO>> Add(SoruUserBulkDTO model)
        {
            if (model.UserId <= 0)
                return new Result<List<SoruUserDTO>>(false, "Kullanıcı bilgisi zorunludur.");

            if (model.Cevaplar == null || !model.Cevaplar.Any())
                return new Result<List<SoruUserDTO>>(false, "Cevap listesi boş olamaz.");

            var partBreakQuestionCount = (int)SimulationPartBreak.FirstPartQuestionCount;

            var totalQuestionCount = _soruRepository.GetAsList(x => true).Count;

            var existingAnsweredQuestionIds = _soruUserRepository
                .GetAsList(x => x.UserId == model.UserId)
                .Select(x => x.SoruId)
                .Distinct()
                .ToList();

            var incomingQuestionIds = model.Cevaplar
                .Select(x => x.SoruId)
                .Distinct()
                .ToList();

            var totalAfterSave = existingAnsweredQuestionIds
                .Union(incomingQuestionIds)
                .Count();

            var isFirstPartSubmit = existingAnsweredQuestionIds.Count == 0;
            var isBreakSubmit = totalAfterSave == partBreakQuestionCount;
            var isFinalSubmit = totalAfterSave == totalQuestionCount;

            if (isFirstPartSubmit && !isBreakSubmit && !isFinalSubmit)
            {
                return new Result<List<SoruUserDTO>>(
                    false,
                    $"{partBreakQuestionCount} soru tamamlanmadan cevaplar kaydedilemez."
                );
            }

            if (!isFirstPartSubmit && !isFinalSubmit)
            {
                return new Result<List<SoruUserDTO>>(
                    false,
                    "Kalan tüm sorular tamamlanmadan cevaplar kaydedilemez."
                );
            }

            var savedList = new List<SoruUserDTO>();

            foreach (var cevap in model.Cevaplar)
            {
                if (cevap.SoruId <= 0)
                    return new Result<List<SoruUserDTO>>(false, "Soru bilgisi eksik.");

                if (string.IsNullOrWhiteSpace(cevap.VerilenCevap))
                    return new Result<List<SoruUserDTO>>(false, "Cevap boş olamaz.");

                var soru = _soruRepository.Get(x => x.Id == cevap.SoruId);

                if (soru == null)
                    return new Result<List<SoruUserDTO>>(false, $"Soru bulunamadı. SoruId: {cevap.SoruId}");

                var dogruCevapKey = soru.DogruCevap != null && soru.DogruCevap.ContainsKey("key")
                    ? soru.DogruCevap["key"]
                    : "";

                var verilenCevap = cevap.VerilenCevap.Trim();
                var dogruCevap = dogruCevapKey.Trim();

                var puan = string.Equals(verilenCevap, dogruCevap, StringComparison.OrdinalIgnoreCase)
                    ? 10
                    : 0;
                _soruUserRepository.ClearTracking();
                var eskiCevap = _soruUserRepository.Get(x =>
                    x.SoruId == cevap.SoruId &&
                    x.UserId == model.UserId
                );

                if (eskiCevap != null)
                {
                    eskiCevap.VerilenCevap = verilenCevap;
                    eskiCevap.Puan = puan;
                    eskiCevap.UpdatedAt = DateTime.Now;

                    eskiCevap.CevaplamaSuresiSaniye = cevap.CevaplamaSuresiSaniye;
                    eskiCevap.AciklamaOkumaSuresiSaniye = cevap.AciklamaOkumaSuresiSaniye;
                    _soruUserRepository.Update(eskiCevap);

                    savedList.Add(_mapper.Map<SoruUserDTO>(eskiCevap));
                }
                else
                {
                    var entity = new SoruUser
                    {
                        SoruId = cevap.SoruId,
                        UserId = model.UserId,
                        VerilenCevap = verilenCevap,
                        Puan = puan,
                        CreatedAt = DateTime.Now,

                        CevaplamaSuresiSaniye = cevap.CevaplamaSuresiSaniye,
                        AciklamaOkumaSuresiSaniye = cevap.AciklamaOkumaSuresiSaniye,
                    };

                    _soruUserRepository.Add(entity);

                    savedList.Add(_mapper.Map<SoruUserDTO>(entity));
                }
            }

            CheckAndCompleteSimulation(model.UserId);

            return new Result<List<SoruUserDTO>>(
                true,
                savedList,
                "Cevaplar başarıyla kaydedildi."
            );
        }
        //public Result<List<UserAnswerReportDTO>> GetUserAnswerReports()
        //{
        //    var answers = _soruUserRepository.GetAsList(
        //        x => true,
        //        include: x => x
        //            .Include(y => y.User)
        //            .Include(y => y.Soru)
        //    );

        //    var cozumlemeAnswers = _cozumlemeSoruUserRepository.GetAsList(
        //        x => true,
        //        include: x => x.Include(y => y.User)
        //    );

        //    var reports = answers
        //        .GroupBy(x => new
        //        {
        //            x.UserId,
        //            UserName = x.User != null ? x.User.FullName : "-"
        //        })
        //        .Select(group => new UserAnswerReportDTO
        //        {
        //            UserId = group.Key.UserId,
        //            UserName = group.Key.UserName,

        //            TotalQuestion = group.Count(),
        //            CorrectCount = group.Count(x => x.Puan == 10),
        //            WrongCount = group.Count(x => x.Puan == 0),
        //            TotalScore = group.Sum(x => x.Puan ?? 0),

        //            SuccessRate = group.Count() == 0
        //                ? 0
        //                : Math.Round((double)group.Count(x => x.Puan == 10) / group.Count() * 100, 2),

        //            Answers = group.Select(x => new UserAnswerDetailDTO
        //            {
        //                CevaplamaSuresiSaniye = x.CevaplamaSuresiSaniye,
        //                AciklamaOkumaSuresiSaniye = x.AciklamaOkumaSuresiSaniye,
        //                SoruId = x.SoruId,
        //                SoruMetni = x.Soru != null ? x.Soru.SoruMetni : "-",
        //                VerilenCevap = x.VerilenCevap,
        //                DogruCevap = x.Soru != null &&
        //                             x.Soru.DogruCevap != null &&
        //                             x.Soru.DogruCevap.ContainsKey("key")
        //                    ? x.Soru.DogruCevap["key"]
        //                    : "-",
        //                Puan = x.Puan
        //            }).ToList(),

        //            CozumlemeSorular = cozumlemeAnswers
        //                .Where(c => c.UserId == group.Key.UserId)
        //                .Select(c => _mapper.Map<CozumlemeSoruUserDTO>(c))
        //                .ToList()
        //        })
        //        .OrderByDescending(x => x.TotalScore)
        //        .ToList();

        //    return new Result<List<UserAnswerReportDTO>>(
        //        true,
        //        reports,
        //        "Kullanıcı cevap raporları listelendi."
        //    );
        //}
        public Result<IPaginate<UserAnswerReportDTO>> GetUserAnswerReports(UserAnswerReportRequestDTO request)
        {
            var answers = _soruUserRepository.GetAsList(
                x => true,
                include: x => x
                    .Include(y => y.User)
                    .Include(y => y.Soru)
            );

            var cozumlemeAnswers = _cozumlemeSoruUserRepository.GetAsList(
                x => true,
                include: x => x.Include(y => y.User)
            );

            var reports = answers
                .GroupBy(x => new
                {
                    x.UserId,
                    UserName = x.User != null ? x.User.UserName : "-",
                    Phone = x.User != null ? x.User.Phone : "-",
                    OgrenciNo = x.User != null ? x.User.OgrenciNo : "-"
                })
                .Select(group => new UserAnswerReportDTO
                {
                    UserId = group.Key.UserId,
                    UserName = group.Key.UserName,

                    Phone = group.Key.Phone,
                    OgrenciNo = group.Key.OgrenciNo,
                    TotalQuestion = group.Count(),
                    CorrectCount = group.Count(x => x.Puan == 10),
                    WrongCount = group.Count(x => x.Puan == 0),
                    TotalScore = group.Sum(x => x.Puan ?? 0),

                    SuccessRate = group.Count() == 0
                        ? 0
                        : Math.Round((double)group.Count(x => x.Puan == 10) / group.Count() * 100, 2),

                    Answers = group.Select(x => new UserAnswerDetailDTO
                    {
                        SoruId = x.SoruId,
                        SoruMetni = x.Soru != null ? x.Soru.SoruMetni : "-",
                        VerilenCevap = x.VerilenCevap,
                        DogruCevap = x.Soru != null &&
                                     x.Soru.DogruCevap != null &&
                                     x.Soru.DogruCevap.ContainsKey("key")
                            ? x.Soru.DogruCevap["key"]
                            : "-",
                        Puan = x.Puan,
                        CevaplamaSuresiSaniye = x.CevaplamaSuresiSaniye,
                        AciklamaOkumaSuresiSaniye = x.AciklamaOkumaSuresiSaniye
                    }).ToList(),

                    CozumlemeSorular = cozumlemeAnswers
                        .Where(c => c.UserId == group.Key.UserId)
                        .Select(c => _mapper.Map<CozumlemeSoruUserDTO>(c))
                        .ToList()
                })
                .OrderByDescending(x => x.TotalScore)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(request.Search))
            {
                var search = request.Search.ToLower();

                reports = reports.Where(x =>
                    x.UserName != null &&
                    x.UserName.ToLower().Contains(search)
                );
            }

            var reportList = reports.ToList();

            var summaryTotalUsers = reportList.Count;
            var summaryTotalAnswers = reportList.Sum(x => x.TotalQuestion);
            var summaryTotalScore = reportList.Sum(x => x.TotalScore); 
            var summaryAverageScore = summaryTotalAnswers == 0
    ? 0
    : Math.Round((double)summaryTotalScore / summaryTotalAnswers, 2);
            var summaryAverageSuccess = reportList.Count == 0
                ? 0
                : Math.Round(reportList.Average(x => x.SuccessRate), 2);

            foreach (var item in reportList)
            {
                item.SummaryTotalUsers = summaryTotalUsers;
                item.SummaryTotalAnswers = summaryTotalAnswers;
                item.SummaryAverageScore = summaryAverageScore;
                item.SummaryAverageSuccess = summaryAverageSuccess;
            }

            var pagedReports = reportList
                .AsQueryable()
                .ToPaginate(
                    index: request.Page,
                    size: request.Size,
                    from: 0
                );

            return new Result<IPaginate<UserAnswerReportDTO>>(
                true,
                pagedReports,
                "Kullanıcı cevap raporları listelendi."
            );
        }
        public Result<UserAnswerExcelExportDTO> GetUserAnswerExcelExportData()
        {
            var answers = _soruUserRepository.GetAsList(
                x => true,
                include: x => x
                    .Include(y => y.User)
                    .Include(y => y.Soru)
            );

            var totalUsers = answers.Select(x => x.UserId).Distinct().Count();
            var totalAnswers = answers.Count;
            var correctCount = answers.Count(x => x.Puan == 10);
            var wrongCount = answers.Count(x => x.Puan == 0);
            var totalScore = answers.Sum(x => x.Puan ?? 0);

            var averageScore = totalAnswers == 0
                ? 0
                : Math.Round((double)totalScore / totalAnswers, 2);

            var successRate = totalAnswers == 0
                ? 0
                : Math.Round((double)correctCount / totalAnswers * 100, 2);

            var avgAnswerTime = totalAnswers == 0
                ? 0
                : Math.Round(answers.Average(x => x.CevaplamaSuresiSaniye ?? 0), 2);

            var avgExplanationTime = totalAnswers == 0
                ? 0
                : Math.Round(answers.Average(x => x.AciklamaOkumaSuresiSaniye ?? 0), 2);

            var summary = new List<UserAnswerExcelSummaryModel>
    {
        new() { Baslik = "Toplam Kullanıcı", Deger = totalUsers.ToString() },
        new() { Baslik = "Toplam Cevap", Deger = totalAnswers.ToString() },
        new() { Baslik = "Doğru Cevap", Deger = correctCount.ToString() },
        new() { Baslik = "Yanlış Cevap", Deger = wrongCount.ToString() },
        new() { Baslik = "Toplam Puan", Deger = totalScore.ToString() },
        new() { Baslik = "Ortalama Puan", Deger = averageScore.ToString() },
        new() { Baslik = "Başarı Oranı (%)", Deger = successRate.ToString() },
        new() { Baslik = "Ortalama Cevaplama Süresi (sn)", Deger = avgAnswerTime.ToString() },
        new() { Baslik = "Ortalama Açıklama Okuma Süresi (sn)", Deger = avgExplanationTime.ToString() },
        new() { Baslik = "Rapor Tarihi", Deger = DateTime.Now.ToString("dd.MM.yyyy HH:mm") }
    };

            var userReports = answers
                .GroupBy(x => new
                {
                    x.UserId,
                    UserName = x.User != null ? x.User.UserName : "-",
                    Username = x.User != null ? x.User.UserName : "-",
                    OgrenciNo = x.User != null ? x.User.OgrenciNo : "-",
                    Phone = x.User != null ? x.User.Phone : "-"
                })
                .Select(g =>
                {
                    var total = g.Count();
                    var correct = g.Count(x => x.Puan == 10);
                    var wrong = g.Count(x => x.Puan == 0);
                    var score = g.Sum(x => x.Puan ?? 0);

                    return new UserAnswerExcelUserReportModel
                    {
                        KullaniciId = g.Key.UserId,
                        AdSoyad = g.Key.UserName,
                        KullaniciAdi = g.Key.Username,
                        OgrenciNo = g.Key.OgrenciNo,
                        Telefon = g.Key.Phone,

                        ToplamCevap = total,
                        DogruSayisi = correct,
                        YanlisSayisi = wrong,

                        ToplamPuan = score,
                        OrtalamaPuan = total == 0 ? 0 : Math.Round((double)score / total, 2),
                        BasariOrani = total == 0 ? 0 : Math.Round((double)correct / total * 100, 2),

                        OrtalamaCevaplamaSuresiSn = Math.Round(g.Average(x => x.CevaplamaSuresiSaniye ?? 0), 2),
                        OrtalamaAciklamaOkumaSuresiSn = Math.Round(g.Average(x => x.AciklamaOkumaSuresiSaniye ?? 0), 2)
                    };
                })
                .OrderByDescending(x => x.OrtalamaPuan)
                .ThenByDescending(x => x.BasariOrani)
                .ToList();

            var details = answers
                .OrderBy(x => x.UserId)
                .ThenBy(x => x.SoruId)
                .Select(x =>
                {
                    var dogruCevap = x.Soru != null &&
                                     x.Soru.DogruCevap != null &&
                                     x.Soru.DogruCevap.ContainsKey("key")
                        ? x.Soru.DogruCevap["key"]
                        : "-";

                    return new UserAnswerExcelDetailModel
                    {
                        KullaniciId = x.UserId,
                        AdSoyad = x.User?.UserName ?? "-",
                        KullaniciAdi = x.User?.UserName ?? "-",
                        OgrenciNo = x.User?.OgrenciNo ?? "-",
                        Telefon = x.User?.Phone ?? "-",
                        SoruMetni = x.Soru?.SoruMetni ?? "-",
                        VerilenCevap = x.VerilenCevap ?? "-",
                        DogruCevap = dogruCevap,
                        Durum = x.Puan == 10 ? "Doğru" : "Yanlış",

                        Puan = x.Puan ?? 0,
                        CevaplamaSuresiSn = x.CevaplamaSuresiSaniye ?? 0,
                        AciklamaOkumaSuresiSn = x.AciklamaOkumaSuresiSaniye ?? 0,

                        CevapTarihi = x.CreatedAt
                    };
                })
                .ToList();

            var exportDto = new UserAnswerExcelExportDTO
            {
                Summary = summary,
                UserReports = userReports,
                Details = details
            };

            return new Result<UserAnswerExcelExportDTO>(
                true,
                exportDto,
                "Excel rapor verisi hazırlandı."
            );
        }
        public Result<bool> Delete(int id)
        {
            var entity = _soruUserRepository.Get(x => x.Id == id);

            if (entity == null)
                return new Result<bool>(false, "Silinecek kayıt bulunamadı");

            _soruUserRepository.Delete(entity);
            return new Result<bool>(true, true, "Kayıt başarıyla silindi");
        }

        public Result<List<SoruUserDTO>> GetAll()
        {
            Result<List<SoruUserDTO>> result;
            var Sorus = _soruUserRepository.GetAsList(orderBy: x => x.OrderByDescending(y => y.Id));
            if (Sorus != null && Sorus.Count > 0)
            {
                List<SoruUserDTO> returnedSorus = _mapper.Map<List<SoruUserDTO>>(Sorus);
                result = new Result<List<SoruUserDTO>>(true, returnedSorus, "Semptom Listesi Başarıyla Getirildi");
                return result;
            }
            result = new Result<List<SoruUserDTO>>(false, "Semptom Listesi Boş");
            return result;
        }

        public Result<SoruUserDTO> GetById(int id)
        {
            var entity = _soruUserRepository.Get(x => x.Id == id);

            if (entity == null)
                return new Result<SoruUserDTO>(false, "Güncellenecek kayıt bulunamadı");


            var resultDto = _mapper.Map<SoruUserDTO>(entity);

            return new Result<SoruUserDTO>(true, resultDto, "Kayıt başarıyla güncellendi");
        }

        public Result<SoruUserDTO> Update(SoruUserDTO model)
        {
            var entity = _soruUserRepository.Get(x => x.Id == model.Id);

            if (entity == null)
                return new Result<SoruUserDTO>(false, "Güncellenecek kayıt bulunamadı");

            _soruUserRepository.Update(entity);

            var resultDto = _mapper.Map<SoruUserDTO>(entity);

            return new Result<SoruUserDTO>(true, resultDto, "Kayıt başarıyla güncellendi");
        }
        public Result<DashboardDTO> GetDashboardData()
        {
            var users = _userRepository.GetAsList(x => true).ToList();

            var answers = _soruUserRepository.GetAsList(
                x => true,
                include: x => x
                    .Include(y => y.User)
                    .Include(y => y.Soru)
            ).ToList();

            var cozumlemeAnswers = _cozumlemeSoruUserRepository.GetAsList(
                x => true,
                include: x => x.Include(y => y.User)
            ).ToList();

            var totalStudents = users.Count;

            var simulationCompleted = users.Count(x => x.SimulasyonTamamlandiMi);
            var analysisCompleted = users.Count(x => x.CozumlemeTamamlandiMi);

            var totalAnswers = answers.Count;
            var correctAnswers = answers.Count(x => x.Puan == 10);
            var wrongAnswers = answers.Count(x => x.Puan == 0);

            var totalScore = answers.Sum(x => x.Puan ?? 0);

            var dashboard = new DashboardDTO
            {
                TotalStudentCount = totalStudents,
                SimulationCompletedCount = simulationCompleted,
                AnalysisCompletedCount = analysisCompleted,

                TotalAnswerCount = totalAnswers,
                CorrectAnswerCount = correctAnswers,
                WrongAnswerCount = wrongAnswers,

                TotalScore = totalScore,

                AverageScore = totalStudents == 0
                    ? 0
                    : Math.Round((double)totalScore / totalStudents, 2),

                SimulationCompletedRate = totalStudents == 0
                    ? 0
                    : Math.Round((double)simulationCompleted / totalStudents * 100, 2),

                AnalysisCompletedRate = totalStudents == 0
                    ? 0
                    : Math.Round((double)analysisCompleted / totalStudents * 100, 2),

                SuccessRate = totalAnswers == 0
                    ? 0
                    : Math.Round((double)correctAnswers / totalAnswers * 100, 2)
            };

            dashboard.TopUsers = answers
                .GroupBy(x => new
                {
                    x.UserId,
                    UserName = x.User != null ? x.User.UserName : "-",
                    OgrenciNo = x.User != null ? x.User.OgrenciNo : "-",
                    Name = x.User != null ? x.User.Name : "-",
                    Surname = x.User != null ? x.User.Surname : "-",
                })
                .Select(group => new DashboardTopUserDTO
                {
                    UserId = group.Key.UserId,
                    UserName = group.Key.UserName,
                    Name = group.Key.Name,
                    Surname = group.Key.Surname,
                    OgrenciNo = group.Key.OgrenciNo,
                    TotalScore = group.Sum(x => x.Puan ?? 0),
                    CorrectCount = group.Count(x => x.Puan == 10),
                    WrongCount = group.Count(x => x.Puan == 0),
                    SuccessRate = group.Count() == 0
                        ? 0
                        : Math.Round((double)group.Count(x => x.Puan == 10) / group.Count() * 100, 2)
                })
                .OrderByDescending(x => x.TotalScore)
                .Take(10)
                .ToList();

            dashboard.ScoreDistribution = new List<DashboardScoreDistributionDTO>
    {
        new DashboardScoreDistributionDTO
        {
            Label = "90+ Puan",
            Count = dashboard.TopUsers.Count(x => x.TotalScore >= 90)
        },
        new DashboardScoreDistributionDTO
        {
            Label = "70 - 89 Puan",
            Count = dashboard.TopUsers.Count(x => x.TotalScore >= 70 && x.TotalScore < 90)
        },
        new DashboardScoreDistributionDTO
        {
            Label = "50 - 69 Puan",
            Count = dashboard.TopUsers.Count(x => x.TotalScore >= 50 && x.TotalScore < 70)
        },
        new DashboardScoreDistributionDTO
        {
            Label = "0 - 49 Puan",
            Count = dashboard.TopUsers.Count(x => x.TotalScore < 50)
        }
    };

            var answerActivities = answers
                .OrderByDescending(x => x.CreatedAt)
                .Take(10)
                .Select(x => new DashboardRecentActivityDTO
                {
                    UserId = x.UserId,
                    UserName = x.User != null ? x.User.UserName : "-",
                    Name = x.User != null ? x.User.Name : "-",
                    Surname = x.User != null ? x.User.Surname : "-",
                    ActivityType = "Soru Cevabı",
                    Description = $"Soruya {x.VerilenCevap} cevabı verildi. Puan: {x.Puan ?? 0}",
                    Date = x.CreatedAt
                });

            var analysisActivities = cozumlemeAnswers
                .OrderByDescending(x => x.CreatedAt)
                .Take(10)
                .Select(x => new DashboardRecentActivityDTO
                {
                    UserId = x.UserId,
                    UserName = x.User != null ? x.User.UserName : "-",
                    Name = x.User != null ? x.User.Name : "-",
                    Surname = x.User != null ? x.User.Surname : "-",
                    ActivityType = "Çözümleme",
                    Description = $"{x.Asama} çözümleme cevabı gönderildi.",
                    Date = x.CreatedAt
                });

            dashboard.RecentActivities = answerActivities
                .Concat(analysisActivities)
                .OrderByDescending(x => x.Date)
                .Take(10)
                .ToList();

            return new Result<DashboardDTO>(
                true,
                dashboard,
                "Dashboard verileri listelendi."
            );
        }
        public Result<MobileCompetitionHomeDTO> GetMobileCompetitionHome(int userId)
        {
            var user = _userRepository.Get(x => x.Id == userId);

            if (user == null)
                return new Result<MobileCompetitionHomeDTO>(false, "Kullanıcı bulunamadı.");

            if (!user.SimulasyonTamamlandiMi)
            {
                return new Result<MobileCompetitionHomeDTO>(
                    false,
                    "Lütfen önce soruları cevaplayınız."
                );
            }

            var users = _userRepository
                .GetAsList(x => x.SimulasyonTamamlandiMi == true)
                .ToList();

            var answers = _soruUserRepository
                .GetAsList(x => true)
                .ToList();

            var rankedUsers = users
                .Select(u =>
                {
                    var userAnswers = answers.Where(a => a.UserId == u.Id).ToList();

                    return new
                    {
                        UserId = u.Id,
                        UserName = u.UserName,
                        TotalScore = userAnswers.Sum(a => a.Puan ?? 0),
                        TotalAnswerCount = userAnswers.Count,
                        CorrectCount = userAnswers.Count(a => a.Puan == 10),
                        WrongCount = userAnswers.Count(a => a.Puan == 0)
                    };
                })
                .OrderByDescending(x => x.TotalScore)
                .ThenBy(x => x.UserName)
                .ToList();

            var rankedWithIndex = rankedUsers
                .Select((x, index) => new MobileLeaderboardUserDTO
                {
                    UserId = x.UserId,
                    UserName = x.UserName,
                    TotalScore = x.TotalScore,
                    Sira = index + 1,
                    IsCurrentUser = x.UserId == userId
                })
                .ToList();

            var currentRank = rankedWithIndex.FirstOrDefault(x => x.UserId == userId);

            if (currentRank == null)
            {
                return new Result<MobileCompetitionHomeDTO>(
                    false,
                    "Kullanıcının sıralama bilgisi bulunamadı."
                );
            }

            var currentStats = rankedUsers.First(x => x.UserId == userId);

            var currentIndex = currentRank.Sira - 1;

            var nearbyUsers = rankedWithIndex
                .Skip(Math.Max(currentIndex - 2, 0))
                .Take(5)
                .ToList();

            var response = new MobileCompetitionHomeDTO
            {
                UserId = user.Id,
                UserName = user.UserName,

                TotalScore = currentStats.TotalScore,
                Rank = currentRank.Sira,
                TotalParticipantCount = rankedWithIndex.Count(),

                TotalAnswerCount = currentStats.TotalAnswerCount,
                CorrectCount = currentStats.CorrectCount,
                WrongCount = currentStats.WrongCount,

                SuccessRate = currentStats.TotalAnswerCount == 0
                    ? 0
                    : Math.Round((double)currentStats.CorrectCount / currentStats.TotalAnswerCount * 100, 2),

                StatusMessage = "Tebrikler, sonuçlarınız hazır.",

                Leaderboard = rankedWithIndex
                    .Take(10)
                    .ToList(),

                NearbyUsers = nearbyUsers
            };

            return new Result<MobileCompetitionHomeDTO>(
                true,
                response,
                "Kullanıcı yarışma ana sayfası getirildi."
            );
        }
    }
}
