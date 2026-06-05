using Core.ResultType;
using DataTransferObject.SoruUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstracts
{
    public interface ISoruUserBL
    {
        Result<SoruUserDTO> Add(SoruUserDTO model);
        Result<SoruUserDTO> Update(SoruUserDTO model);
        Result<bool> Delete(int id);
        Result<SoruUserDTO> GetById(int id);
        Result<List<SoruUserDTO>> GetAll();
    }
}
