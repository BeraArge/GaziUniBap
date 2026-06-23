using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.SoruUser.Excel
{
    public class UserAnswerExcelUserReportModel
    {
        public int KullaniciId { get; set; }
        public string AdSoyad { get; set; }
        public string KullaniciAdi { get; set; }
        public string OgrenciNo { get; set; }
        public string Telefon { get; set; }

        public int ToplamCevap { get; set; }
        public int DogruSayisi { get; set; }
        public int YanlisSayisi { get; set; }

        public int ToplamPuan { get; set; }
        public double OrtalamaPuan { get; set; }
        public double BasariOrani { get; set; }

        public double OrtalamaCevaplamaSuresiSn { get; set; }
        public double OrtalamaAciklamaOkumaSuresiSn { get; set; }
    }
}
