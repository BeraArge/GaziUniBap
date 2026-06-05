using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.SoruUser
{
    public class SoruUserDTO
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int SoruId { get; set; }
        public int UserId { get; set; }
        public string VerilenCevap { get; set; }
        public int? Puan { get; set; }
    }
}
