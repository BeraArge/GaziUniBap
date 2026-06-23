using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.User.KullaniciIslemleri
{
    public class UserListRequestDto
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 10;

        public string? Search { get; set; }
        public int? RoleId { get; set; }
    }
}
