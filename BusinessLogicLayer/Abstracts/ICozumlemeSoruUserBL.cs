using Core.ResultType;
using DataTransferObject.CozumlemeSoruUser;
using DataTransferObject.SoruUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstracts
{
    public interface ICozumlemeSoruUserBL
    {

        Result<CozumlemeSoruUserDTO> Add(CozumlemeSoruUserDTO model);
        Result<CozumlemeSoruUserDTO> Update(CozumlemeSoruUserDTO model);
        Result<bool> Delete(int id);
        Result<CozumlemeSoruUserDTO> GetById(int id);
        Result<List<CozumlemeSoruUserDTO>> GetAll();
    }
}
