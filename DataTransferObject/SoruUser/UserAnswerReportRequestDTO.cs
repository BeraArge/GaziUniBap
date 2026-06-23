using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.SoruUser
{
    public class UserAnswerReportRequestDTO
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 6;
        public string? Search { get; set; }
    }
}
