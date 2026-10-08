using Core.ResultType;
using DataTransferObject.OnBlgilendirme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstracts
{
    public interface IOnBilgilendirmeBL
    {
        Result<OnBilgilendirmeDTO> Add(OnBilgilendirmeDTO model);
        Result<OnBilgilendirmeDTO> Update(OnBilgilendirmeDTO model);
        Result<OnBilgilendirmeDTO> GetOnBilgilendirme();
    }
}
