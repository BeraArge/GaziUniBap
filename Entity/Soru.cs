using Core.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Soru:BaseEntity
    {
        public string VideoPath { get; set; }
        public string VideoTranscript { get; set; }
        public string Hedef { get; set; }
        public string OlcekMaddesi { get; set; }
        public string SoruMetni { get; set; }//soru metni
        [Column(TypeName = "jsonb")]
        public List<Dictionary<string,string>> Cevaplar { get; set; }//a,şık b,şık
        [Column(TypeName = "jsonb")]
        public Dictionary<string,string> DogruCevap { get; set; }//dogru olan cevap ve dogruluk aciklamasi
        public HashSet<SoruUser> SoruUsers { get; set; }
    }
}
