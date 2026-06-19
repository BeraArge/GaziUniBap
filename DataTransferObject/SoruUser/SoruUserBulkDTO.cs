using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.SoruUser
{
    public class SoruUserBulkDTO
    {
        public int UserId { get; set; }
        public List<SoruUserDTO> Cevaplar { get; set; } = new();
    }
}
