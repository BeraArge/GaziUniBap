using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.CozumlemeSoruUser
{
    public class CozumlemeSoruUserDTO
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int UserId { get; set; }
        public string Asama { get; set; }
        [Column(TypeName = "jsonb")]
        public List<Dictionary<string, string>> SoruCevap { get; set; }
    }
}
