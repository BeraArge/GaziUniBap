using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.User
{
    public class PasswordModel
    {
        public int Id { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string NewPasswordRepeat { get; set; }
    }
}
