using DataTransferObject.CozumlemeSoruUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.SoruUser
{
    public class UserAnswerReportDTO
    {
        public int UserId { get; set; }
        public string UserName { get; set; }

        public int TotalQuestion { get; set; }
        public int CorrectCount { get; set; }
        public int WrongCount { get; set; }
        public string? Phone { get; set; }
        public string? OgrenciNo { get; set; }
        public int TotalScore { get; set; }

        public double SuccessRate { get; set; }
        public List<CozumlemeSoruUserDTO> CozumlemeSorular { get; set; }
        public List<UserAnswerDetailDTO> Answers { get; set; }
    }
}
