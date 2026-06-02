using AutoMapper;
using DataTransferObject.Notification;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.AutoMapperProfiles
{
    public class NotificationProfile : Profile
    {
        public NotificationProfile()
        {
            CreateMap<Notification, NotificationDTO>().ReverseMap();
        }
    }
}
