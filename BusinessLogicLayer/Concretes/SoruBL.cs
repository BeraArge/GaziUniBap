using AutoMapper;
using BusinessLogicLayer.Abstracts;
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
            Result<SoruDTO> result;
            if (model != null)
            {

                Soru addedSoru = _mapper.Map<Soru>(model);
                _soruRepository.Add(addedSoru);

                result = new Result<SoruDTO>(true, model, "Soru Eklendi.");
                return result;
            }
            result = new Result<SoruDTO>(false, "Soru Eklenirken Bir Hata Oluştu.");
            return result;
        }

        public Result<bool> Delete(int id)
        {
            var entity = _soruRepository.Get(x => x.Id == id);

            if (entity == null)
                return new Result<bool>(false, "Silinecek kayıt bulunamadı");

            _soruRepository.Delete(entity);
            return new Result<bool>(true, true, "Kayıt başarıyla silindi");
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
                return new Result<MobileSoruListResponseDTO>(false, "Kullanıcı bulunamadı.");

            if (user.SimulasyonTamamlandiMi)
            {
                return new Result<MobileSoruListResponseDTO>(
                    false,
                    "Simülasyonu tamamladınız. Tekrar başlayamazsınız."
                );
            }

            var partBreakQuestionCount = (int)SimulationPartBreak.FirstPartQuestionCount;

            var tumSorular = _soruRepository
                .GetAsList(x => true)
                .OrderBy(x => x.Id)
                .ToList();

            var cevaplananSoruSayisi = _soruUserRepository
                .GetAsList(x => x.UserId == userId)
                .Select(x => x.SoruId)
                .Distinct()
                .Count();

            var ilkPartTamamlandiMi = cevaplananSoruSayisi >= partBreakQuestionCount;

            var gonderilecekSorular = ilkPartTamamlandiMi
                ? tumSorular.Skip(partBreakQuestionCount).ToList()
                : tumSorular;

            var data = gonderilecekSorular
                .Select((x, index) => new SoruDTO
                {
                    Id = x.Id,
                    VideoPath = x.VideoPath, 
                    VideoTranscript = x.VideoTranscript,
                    Hedef = x.Hedef,
                    OlcekMaddesi = x.OlcekMaddesi,
                    SoruMetni = x.SoruMetni,
                    Cevaplar = x.Cevaplar,
                    DogruCevap=x.DogruCevap,
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

            _soruRepository.Update(entity);

            var resultDto = _mapper.Map<SoruDTO>(entity);

            return new Result<SoruDTO>(true, resultDto, "Kayıt başarıyla güncellendi");
        }
    }
}
