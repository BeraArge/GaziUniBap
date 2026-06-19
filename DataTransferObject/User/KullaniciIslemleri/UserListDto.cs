using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.User.KullaniciIslemleri
{
    public class UserListDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string Phone { get; set; }
        public string RoleName { get; set; }
        public int RoleId { get; set; }
        public bool KvkkApproved { get; set; }
        public bool OnamApproved { get; set; }
        public bool IlkGiris { get; set; }
        public string? OgrenciNo { get; set; }

        public bool SimulasyonTamamlandiMi { get; set; }
        public bool CozumlemeTamamlandiMi { get; set; }

        public int? ToplamPuan { get; set; }

    }

}
