using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.User
{
    public class OgrenciLoginDTO
    {
        public string OgrenciNo { get; set; }
        public string Password { get; set; }
        public string? DeviceToken { get; set; }
    }
}
