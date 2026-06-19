using Core.ResultType;
using DataTransferObject.Soru;
using DataTransferObject.SoruUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstracts
{
    public interface ISoruBL
    {
        Result<SoruDTO> Add(SoruDTO model);
        Result<SoruDTO> Update(SoruDTO model);
        Result<bool> Delete(int id);
        Result<SoruDTO> GetById(int id);
        Result<List<SoruDTO>> GetAll();
        Result<MobileSoruListResponseDTO> GetMobileSorular(int userId);
    }
}
