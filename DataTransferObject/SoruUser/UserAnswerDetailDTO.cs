using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.SoruUser
{
    public class UserAnswerDetailDTO
    {
        public int SoruId { get; set; }
        public string SoruMetni { get; set; }
        public string VerilenCevap { get; set; }
        public string DogruCevap { get; set; }
        public int? Puan { get; set; }
        public int? CevaplamaSuresiSaniye { get; set; }
        public int? AciklamaOkumaSuresiSaniye { get; set; }
    }
}
