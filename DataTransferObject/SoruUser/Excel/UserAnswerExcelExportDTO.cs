using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.SoruUser.Excel
{
    public class UserAnswerExcelExportDTO
    {
        public List<UserAnswerExcelSummaryModel> Summary { get; set; } = new();
        public List<UserAnswerExcelUserReportModel> UserReports { get; set; } = new();
        public List<UserAnswerExcelDetailModel> Details { get; set; } = new();
    }
}
