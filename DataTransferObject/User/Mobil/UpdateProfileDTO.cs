using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.User.Mobil
{
    public class UpdateProfileDTO
    {
        public int UserId { get; set; }
        public string? FullName { get; set; }
        public string Phone { get; set; }
    }
}
