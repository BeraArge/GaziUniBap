using Core.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class SoruUser:BaseEntity
    {
        public int SoruId { get; set; }
        public int UserId { get; set; }
        public string VerilenCevap { get; set; }
        public int? Puan { get; set; }
        public int? CevaplamaSuresiSaniye { get; set; }
        public int? AciklamaOkumaSuresiSaniye { get; set; }
        public Soru? Soru { get; set; }
        public User? User { get; set; }
    }
}
