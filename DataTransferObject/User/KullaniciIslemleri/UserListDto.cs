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
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string RoleName { get; set; }
        public int RoleId { get; set; }
        public bool KvkkApproved { get; set; }
        public bool OnamApproved { get; set; }
        public bool IlkGiris { get; set; }
    }

}
