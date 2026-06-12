using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.User.KullaniciIslemleri
{
    public class UserCreateDto
    {
        
        public string? FullName { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? OgrenciNo { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string PasswordRepeat { get; set; }
        public int RoleId { get; set; }
    }

}
