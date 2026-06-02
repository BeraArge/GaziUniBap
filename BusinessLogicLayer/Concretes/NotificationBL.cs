using AutoMapper;
using BusinessLogicLayer.Abstracts;
using Core.ResultType;
using DataAccessLayer.EntityFramework.Abstracts;
using DataTransferObject.Notification;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concretes
{
    public class NotificationBL : INotificationBL
    {
        private readonly INotificationRepository _notificationRepository;
        private readonly IMapper _mapper;

        public NotificationBL(IMapper mapper, INotificationRepository notificationRepository)
        {
            _mapper = mapper;
            _notificationRepository = notificationRepository;
        }

        public Result<NotificationDTO> Add(NotificationDTO model)
        {
            Result<NotificationDTO> result;

            if(model != null)
            {
                Notification notification = _mapper.Map<Notification>(model);
                _notificationRepository.Add(notification);

                result = new Result<NotificationDTO>(true, model, "Bildirim Kaydedildi.");
                return result;
            }
            result = new Result<NotificationDTO>(false, "Bildirim Kaydı Başarısız Oldu.");
            return result;
        }

        public Result<List<NotificationDTO>> GetAllNotification()
        {
            Result<List<NotificationDTO>> result;

            List<Notification> notifications = _notificationRepository.GetAsList(orderBy:x=>x.OrderByDescending(y=>y.Id));

            if(notifications != null && notifications.Count > 0)
            {
                List<NotificationDTO> notificationDTOs = _mapper.Map<List<NotificationDTO>>(notifications);
                result = new Result<List<NotificationDTO>>(true, notificationDTOs, "Bildirim Listesi Getirildi.");
                return result;
            }
            result = new Result<List<NotificationDTO>>(false, "Bildirim Kaydı Bulunamadı.");
            return result;
        }
    }
}
