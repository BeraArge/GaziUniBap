using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.Soru
{
    public class MobileSoruListResponseDTO
    {
        public int UserId { get; set; }
        public int BaslangicIndex { get; set; }
        public int? BaslangicSoruId { get; set; }
        public int CevaplananSoruSayisi { get; set; }
        public int PartBreakQuestionCount { get; set; }
        public bool IlkPartTamamlandiMi { get; set; }
        public bool SimulasyonTamamlandiMi { get; set; }
        public int KalanSoruSayisi { get; set; }
        public List<Dictionary<string, string>> Cevaplar { get; set; }
        public string DogruCevapKey { get; set; }
        public string DogruCevapAciklama { get; set; }
        public List<SoruDTO> Sorular { get; set; } = new();
    }
}
