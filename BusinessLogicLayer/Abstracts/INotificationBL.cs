using Core.ResultType;
using DataTransferObject.Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstracts
{
    public interface INotificationBL 
    {
        Result<NotificationDTO> Add(NotificationDTO model);
        Result<List<NotificationDTO>> GetAllNotification();
    }
}
