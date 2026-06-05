using AutoMapper;
using DataTransferObject.Notification;
using DataTransferObject.Soru;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.AutoMapperProfiles
{
    public class SoruProfile : Profile
    {
        public SoruProfile()
        {
            CreateMap<Soru, SoruDTO>().ReverseMap();
        }
    }
}
