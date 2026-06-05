using AutoMapper;
using DataTransferObject.Notification;
using DataTransferObject.SoruUser;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.AutoMapperProfiles
{
    public class SoruUserProfile : Profile
    {
        public SoruUserProfile()
        {
            CreateMap<SoruUser, SoruUserDTO>().ReverseMap();
        }
    }
}
