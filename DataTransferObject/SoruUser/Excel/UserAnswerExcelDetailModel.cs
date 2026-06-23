using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.SoruUser.Excel
{
    public class UserAnswerExcelDetailModel
    {
        public int KullaniciId { get; set; }
        public string AdSoyad { get; set; }
        public string KullaniciAdi { get; set; }
        public string OgrenciNo { get; set; }
        public string Telefon { get; set; }
        public string SoruMetni { get; set; }
        public string VerilenCevap { get; set; }
        public string DogruCevap { get; set; }
        public string Durum { get; set; }

        public int Puan { get; set; }
        public int CevaplamaSuresiSn { get; set; }
        public int AciklamaOkumaSuresiSn { get; set; }

        public DateTime? CevapTarihi { get; set; }
    }
}
