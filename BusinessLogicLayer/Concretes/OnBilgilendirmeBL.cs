using AutoMapper;
using BusinessLogicLayer.Abstracts;
using Core.ResultType;
using DataAccessLayer.EntityFramework.Abstracts;
using DataAccessLayer.EntityFramework.Concretes;
using DataTransferObject.OnBlgilendirme;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concretes
{
    public class OnBilgilendirmeBL : IOnBilgilendirmeBL
    {
        private readonly IOnBilgilendirmeRepository _onBilgilendirmeRepository;
        private readonly IMapper _mapper;

        public OnBilgilendirmeBL(IOnBilgilendirmeRepository onBilgilendirmeRepository, IMapper mapper)
        {
            _onBilgilendirmeRepository = onBilgilendirmeRepository;
            _mapper = mapper;
        }

        public Result<OnBilgilendirmeDTO> Add(OnBilgilendirmeDTO model)
        {
            if (model == null)
                return new Result<OnBilgilendirmeDTO>(false, "Veri boş olamaz.");

            if (string.IsNullOrWhiteSpace(model.OnBilgilendirmeMetni))
                return new Result<OnBilgilendirmeDTO>(false, "Ön bilgilendirme metni boş olamaz.");

            var entity = _onBilgilendirmeRepository
                .GetAsList(x => true)
                .OrderBy(x => x.Id)
                .FirstOrDefault();

            if (entity == null)
            {
                entity = new OnBilgilendirme
                {
                    OnBilgilendirmeMetni = model.OnBilgilendirmeMetni,
                    CreatedAt = DateTime.Now
                };

                _onBilgilendirmeRepository.Add(entity);
            }
            else
            {
                entity.OnBilgilendirmeMetni = model.OnBilgilendirmeMetni;
                entity.UpdatedAt = DateTime.Now;

                _onBilgilendirmeRepository.Update(entity);
            }

            var dto = new OnBilgilendirmeDTO
            {
                Id = entity.Id,
                OnBilgilendirmeMetni = entity.OnBilgilendirmeMetni
            };

            return new Result<OnBilgilendirmeDTO>(
                true,
                dto,
                "Ön bilgilendirme başarıyla kaydedildi."
            );
        } 
        public Result<OnBilgilendirmeDTO> Update(OnBilgilendirmeDTO model)
        {
            var entity = _onBilgilendirmeRepository.Get(x => x.Id == model.Id);

            if (entity == null)
                return new Result<OnBilgilendirmeDTO>(false, "Güncellenecek kayıt bulunamadı");

            entity.OnBilgilendirmeMetni = model.OnBilgilendirmeMetni;

            _onBilgilendirmeRepository.Update(entity);

            var resultDto = _mapper.Map<OnBilgilendirmeDTO>(entity);

            return new Result<OnBilgilendirmeDTO>(true, resultDto, "Kayıt başarıyla güncellendi");
        }
        public Result<OnBilgilendirmeDTO> GetOnBilgilendirme()
        {
            var entity = _onBilgilendirmeRepository
                .GetAsList(x => true)
                .OrderBy(x => x.Id)
                .FirstOrDefault();

            if (entity == null)
            {
                return new Result<OnBilgilendirmeDTO>(
                    true,
                    new OnBilgilendirmeDTO
                    {
                        Id = 0,
                        OnBilgilendirmeMetni = ""
                    },
                    "Ön bilgilendirme bulunamadı."
                );
            }

            return new Result<OnBilgilendirmeDTO>(
                true,
                new OnBilgilendirmeDTO
                {
                    Id = entity.Id,
                    OnBilgilendirmeMetni = entity.OnBilgilendirmeMetni
                },
                "Ön bilgilendirme getirildi."
            );
        }
    }
}
