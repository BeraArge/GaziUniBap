using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.Notification
{
    public class NotificationDTO
    {
        public string Message { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
