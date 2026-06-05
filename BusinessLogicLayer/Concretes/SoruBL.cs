using AutoMapper;
using BusinessLogicLayer.Abstracts;
using Core.ResultType;
using DataAccessLayer.EntityFramework.Abstracts;
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

        public SoruBL(IMapper mapper, ISoruRepository soruRepository)
        {
            _mapper = mapper;
            _soruRepository = soruRepository;
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

        public Result<SoruDTO> GetById(int id)
        {
            var entity = _soruRepository.Get(x => x.Id == id);

            if (entity == null)
                return new Result<SoruDTO>(false, "Güncellenecek kayıt bulunamadı");


            var resultDto = _mapper.Map<SoruDTO>(entity);

            return new Result<SoruDTO>(true, resultDto, "Kayıt başarıyla güncellendi");
        }

        public Result<SoruDTO> Update(SoruDTO model)//düzenlenecek
        {
            var entity = _soruRepository.Get(x => x.Id == model.Id);

            if (entity == null)
                return new Result<SoruDTO>(false, "Güncellenecek kayıt bulunamadı");

            _soruRepository.Update(entity);

            var resultDto = _mapper.Map<SoruDTO>(entity);

            return new Result<SoruDTO>(true, resultDto, "Kayıt başarıyla güncellendi");
        }
    }
}
