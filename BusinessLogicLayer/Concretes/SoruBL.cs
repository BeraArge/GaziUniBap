using AutoMapper;
using BusinessLogicLayer.Abstracts;
using Core.DataAccess.Repositories;
using Core.Enums;
using Core.ResultType;
using DataAccessLayer.EntityFramework.Abstracts;
using DataAccessLayer.EntityFramework.Concretes;
using DataTransferObject.Soru;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concretes
{
    public class SoruBL : ISoruBL
    {
        private readonly IMapper _mapper;
        private readonly ISoruRepository _soruRepository;
        private readonly IUserRepository _userRepository;
        private readonly ISoruUserRepository _soruUserRepository;

        public SoruBL(IMapper mapper, ISoruRepository soruRepository, IUserRepository userRepository, ISoruUserRepository soruUserRepository)
        {
            _mapper = mapper;
            _soruRepository = soruRepository;
            _userRepository = userRepository;
            _soruUserRepository = soruUserRepository;
        }


        public Result<SoruDTO> Add(SoruDTO model)
        {
            if (model == null)
            {
                return new Result<SoruDTO>(
                    false,
                    "Soru eklenirken bir hata oluştu."
                );
            }

            // Mevcut içeriklerin en büyük Order değerini bul
            var mevcutSorular = _soruRepository.GetAsList(x => true);

            var maxOrder = mevcutSorular
                .Select(x => x.Order ?? 0)
                .DefaultIfEmpty(0)
                .Max();

            // DTO'yu Entity'ye dönüştür
            Soru addedSoru = _mapper.Map<Soru>(model);

            // Yeni içeriği otomatik olarak son sıraya ekle
            addedSoru.Order = maxOrder + 1;

            // Veritabanına kaydet
            _soruRepository.Add(addedSoru);

            // Oluşturulan sıra numarasını DTO'ya da aktar
            model.Order = addedSoru.Order;

            return new Result<SoruDTO>(
                true,
                model,
                "İçerik başarıyla eklendi."
            );
        }



        public Result<bool> Delete(int id)
        {
            if (id <= 0)
            {
                return new Result<bool>(
                    false,
                    "Geçersiz içerik ID değeri."
                );
            }

            var soru = _soruRepository.Get(x => x.Id == id);

            if (soru == null)
            {
                return new Result<bool>(
                    false,
                    "Silinecek içerik bulunamadı."
                );
            }

            var silinenOrder = soru.Order;

            // Önce içeriği sil
            _soruRepository.Delete(soru);

            // Silinen içeriğin sonrasındaki kayıtları
            // bir sıra öne taşı
            if (silinenOrder.HasValue)
            {
                var sonrakiSorular = _soruRepository
                    .GetAsList(x => x.Order > silinenOrder.Value)
                    .OrderBy(x => x.Order)
                    .ToList();

                foreach (var item in sonrakiSorular)
                {
                    item.Order = item.Order.Value - 1;
                    _soruRepository.Update(item);
                }
            }

            return new Result<bool>(
                true,
                true,
                "İçerik başarıyla silindi."
            );
        }


        public Result<List<SoruDTO>> GetAll()
        {
            Result<List<SoruDTO>> result;
            var Sorus = _soruRepository.GetAsList(orderBy: x => x.OrderByDescending(y => y.Id));
            if (Sorus != null && Sorus.Count > 0)
            {
                List<SoruDTO> returnedSorus = _mapper.Map<List<SoruDTO>>(Sorus);
                result = new Result<List<SoruDTO>>(true, returnedSorus, "Soru Listesi Başarıyla Getirildi");
                return result;
            }
            result = new Result<List<SoruDTO>>(false, "Soru Listesi Boş");
            return result;
        }

        public Result<MobileSoruListResponseDTO> GetMobileSorular(int userId)
        {
            var user = _userRepository.Get(x => x.Id == userId);

            if (user == null)
                return new Result<MobileSoruListResponseDTO>(
                    false,
                    "Kullanıcı bulunamadı."
                );

            if (user.SimulasyonTamamlandiMi)
            {
                return new Result<MobileSoruListResponseDTO>(
                    false,
                    "Simülasyonu tamamladınız. Tekrar başlayamazsınız."
                );
            }

            var partBreakQuestionCount =
                (int)SimulationPartBreak.FirstPartQuestionCount;

            // İçerikleri Order alanına göre sıralıyoruz.
            // Order değeri olmayan eski kayıtlar sona alınır.
            // Aynı Order değerine sahip kayıtlar Id ile sıralanır.
            var tumSorular = _soruRepository
                .GetAsList(x => true)
                .OrderBy(x => x.Order ?? int.MaxValue)
                .ThenBy(x => x.Id)
                .ToList();

            var cevaplananSoruSayisi = _soruUserRepository
                .GetAsList(x => x.UserId == userId)
                .Select(x => x.SoruId)
                .Distinct()
                .Count();

            var ilkPartTamamlandiMi =
                cevaplananSoruSayisi >= partBreakQuestionCount;

            var gonderilecekSorular = ilkPartTamamlandiMi
                ? tumSorular.Skip(partBreakQuestionCount).ToList()
                : tumSorular;

            var data = gonderilecekSorular
                .Select((x, index) => new SoruDTO
                {
                    Id = x.Id,

                    // İçerik sırası
                    Order = x.Order,

                    // Video bilgileri
                    VideoPath = x.VideoPath,
                    VideoTranscript = x.VideoTranscript,

                    // Soru bilgileri
                    Hedef = x.Hedef,
                    OlcekMaddesi = x.OlcekMaddesi,
                    SoruMetni = x.SoruMetni,
                    Cevaplar = x.Cevaplar,
                    DogruCevap = x.DogruCevap,

                    // Bekleme ve bildirim bilgileri
                    BeklemeSuresi = x.BeklemeSuresi,
                    BildirimMetni = x.BildirimMetni,

                    // İlk partın son içeriğini işaretliyoruz
                    PartArasiMi = !ilkPartTamamlandiMi &&
                                  (index + 1) == partBreakQuestionCount
                })
                .ToList();

            var response = new MobileSoruListResponseDTO
            {
                UserId = userId,
                CevaplananSoruSayisi = cevaplananSoruSayisi,
                PartBreakQuestionCount = partBreakQuestionCount,
                IlkPartTamamlandiMi = ilkPartTamamlandiMi,
                SimulasyonTamamlandiMi = false,
                KalanSoruSayisi = data.Count,
                Sorular = data
            };

            return new Result<MobileSoruListResponseDTO>(
                true,
                response,
                ilkPartTamamlandiMi
                    ? "İlk part tamamlandı. Simülasyon ikinci parttan devam edecek."
                    : "Sorular listelendi."
            );
        }

        public Result<SoruDTO> GetById(int id)
        {
            var entity = _soruRepository.Get(x => x.Id == id);

            if (entity == null)
                return new Result<SoruDTO>(false, "Güncellenecek kayıt bulunamadı");


            var resultDto = _mapper.Map<SoruDTO>(entity);

            return new Result<SoruDTO>(true, resultDto, "Kayıt başarıyla güncellendi");
        }

        public Result<SoruDTO> Update(SoruDTO model)
        {
            var entity = _soruRepository.Get(x => x.Id == model.Id);

            if (entity == null)
                return new Result<SoruDTO>(false, "Güncellenecek kayıt bulunamadı");
            if (!string.IsNullOrWhiteSpace(model.VideoPath))
            {
                entity.VideoPath = model.VideoPath;
            }
            entity.Hedef = model.Hedef;
            entity.OlcekMaddesi = model.OlcekMaddesi;
            entity.SoruMetni = model.SoruMetni;
            entity.Cevaplar = model.Cevaplar;
            entity.VideoTranscript = model.VideoTranscript;
            entity.DogruCevap = model.DogruCevap;
            entity.UpdatedAt = DateTime.Now;
            entity.Order = model.Order;
            entity.BeklemeSuresi = model.BeklemeSuresi;
            entity.BildirimMetni = model.BildirimMetni;

            _soruRepository.Update(entity);

            var resultDto = _mapper.Map<SoruDTO>(entity);

            return new Result<SoruDTO>(true, resultDto, "Kayıt başarıyla güncellendi");
        }
    }
}
