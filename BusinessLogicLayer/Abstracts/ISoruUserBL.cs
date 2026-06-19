using Core.ResultType;
using DataTransferObject.Home;
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
        Result<List<SoruUserDTO>> Add(SoruUserBulkDTO model);
        Result<SoruUserDTO> Update(SoruUserDTO model);
        Result<bool> Delete(int id);
        Result<SoruUserDTO> GetById(int id);
        Result<List<SoruUserDTO>> GetAll();
        Result<MobileCompetitionHomeDTO> GetMobileCompetitionHome(int userId);
        Result<List<UserAnswerReportDTO>> GetUserAnswerReports();
        Result<DashboardDTO> GetDashboardData();
    }
}
