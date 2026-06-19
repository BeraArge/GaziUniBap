using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.Soru
{
    public class SoruDTO
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string VideoPath { get; set; }
        public string VideoTranscript { get; set; }
        public bool PartArasiMi { get; set; }
        public IFormFile? VideoFile { get; set; }
        public string Hedef { get; set; }
        public string OlcekMaddesi { get; set; }
        public string SoruMetni { get; set; }//soru metni
        [Column(TypeName = "jsonb")]
        public List<Dictionary<string, string>> Cevaplar { get; set; }//a,şık b,şık
        [Column(TypeName = "jsonb")]
        public Dictionary<string, string> DogruCevap { get; set; }//dogru olan cevap ve dogruluk aciklamasi
    }
}
