using AutoMapper;
using DataTransferObject.CozumlemeSoruUser;
using DataTransferObject.Notification;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.AutoMapperProfiles
{
    public class CozumlemeSoruUserProfile : Profile
    {
        public CozumlemeSoruUserProfile()
        {
            CreateMap<CozumlemeSoruUser , CozumlemeSoruUserDTO>().ReverseMap();
        }
    }
}
