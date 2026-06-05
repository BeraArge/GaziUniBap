using AutoMapper;
using BusinessLogicLayer.Abstracts;
using Core.ResultType;
using DataAccessLayer.EntityFramework.Abstracts;
using DataTransferObject.Soru;
using DataTransferObject.SoruUser;
using Entity;
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
        private readonly IMapper _mapper;

        public SoruUserBL(ISoruUserRepository soruUserRepository, IMapper mapper)
        {
            _soruUserRepository = soruUserRepository;
            _mapper = mapper;
        }

        public Result<SoruUserDTO> Add(SoruUserDTO model)
        {
            Result<SoruUserDTO> result;
            if (model != null)
            {

                SoruUser addedSoru = _mapper.Map<SoruUser>(model);
                _soruUserRepository.Add(addedSoru);

                result = new Result<SoruUserDTO>(true, model, "Semptom Eklendi.");
                return result;
            }
            result = new Result<SoruUserDTO>(false, "Semptom Eklenemedi, Semptom Başlığı zorunlu.");
            return result;
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
    }
}
