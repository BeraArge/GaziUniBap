using AutoMapper;
using BusinessLogicLayer.Abstracts;
using Core.ResultType;
using DataAccessLayer.EntityFramework.Abstracts;
using DataTransferObject.CozumlemeSoruUser;
using DataTransferObject.SoruUser;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concretes
{
    public class CozumlemeSoruUserBL : ICozumlemeSoruUserBL
    {
        private readonly ICozumlemeSoruUserRepository _cozumlemeSoruUserRepository;

        private readonly IMapper _mapper;

        public CozumlemeSoruUserBL(ICozumlemeSoruUserRepository cozumlemeSoruUserRepository, IMapper mapper)
        {
            _cozumlemeSoruUserRepository = cozumlemeSoruUserRepository;
            _mapper = mapper;
        }

        public Result<CozumlemeSoruUserDTO> Add(CozumlemeSoruUserDTO model)
        {
            Result<CozumlemeSoruUserDTO> result;
            if (model != null)
            {

                CozumlemeSoruUser addedSoru = _mapper.Map<CozumlemeSoruUser>(model);
                _cozumlemeSoruUserRepository.Add(addedSoru);

                result = new Result<CozumlemeSoruUserDTO>(true, model, "Semptom Eklendi.");
                return result;
            }
            result = new Result<CozumlemeSoruUserDTO>(false, "Semptom Eklenemedi, Semptom Başlığı zorunlu.");
            return result;
        }

        public Result<bool> Delete(int id)
        {
            var entity = _cozumlemeSoruUserRepository.Get(x => x.Id == id);

            if (entity == null)
                return new Result<bool>(false, "Silinecek kayıt bulunamadı");

            _cozumlemeSoruUserRepository.Delete(entity);
            return new Result<bool>(true, true, "Kayıt başarıyla silindi");
        }

        public Result<List<CozumlemeSoruUserDTO>> GetAll()
        {
            Result<List<CozumlemeSoruUserDTO>> result;
            var Sorus = _cozumlemeSoruUserRepository.GetAsList(orderBy: x => x.OrderByDescending(y => y.Id));
            if (Sorus != null && Sorus.Count > 0)
            {
                List<CozumlemeSoruUserDTO> returnedSorus = _mapper.Map<List<CozumlemeSoruUserDTO>>(Sorus);
                result = new Result<List<CozumlemeSoruUserDTO>>(true, returnedSorus, "Semptom Listesi Başarıyla Getirildi");
                return result;
            }
            result = new Result<List<CozumlemeSoruUserDTO>>(false, "Semptom Listesi Boş");
            return result;
        }

        public Result<CozumlemeSoruUserDTO> GetById(int id)
        {
            var entity = _cozumlemeSoruUserRepository.Get(x => x.Id == id);

            if (entity == null)
                return new Result<CozumlemeSoruUserDTO>(false, "Güncellenecek kayıt bulunamadı");


            var resultDto = _mapper.Map<CozumlemeSoruUserDTO>(entity);

            return new Result<CozumlemeSoruUserDTO>(true, resultDto, "Kayıt başarıyla güncellendi");

        }

        public Result<CozumlemeSoruUserDTO> Update(CozumlemeSoruUserDTO model)
        {
            var entity = _cozumlemeSoruUserRepository.Get(x => x.Id == model.Id);

            if (entity == null)
                return new Result<CozumlemeSoruUserDTO>(false, "Güncellenecek kayıt bulunamadı");

            _cozumlemeSoruUserRepository.Update(entity);

            var resultDto = _mapper.Map<CozumlemeSoruUserDTO>(entity);

            return new Result<CozumlemeSoruUserDTO>(true, resultDto, "Kayıt başarıyla güncellendi");

        }
    }
}
