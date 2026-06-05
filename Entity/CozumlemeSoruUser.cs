using Core.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CozumlemeSoruUser : BaseEntity
    {
        public int UserId { get; set; }
        public string Asama { get; set; }
        [Column(TypeName = "jsonb")]
        public List<Dictionary<string,string>> SoruCevap { get; set; }
        public User? User { get; set; }
    }
}
