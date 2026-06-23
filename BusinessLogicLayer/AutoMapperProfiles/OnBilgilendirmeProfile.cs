using AutoMapper;
using DataTransferObject.CozumlemeSoruUser;
using DataTransferObject.OnBlgilendirme;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.AutoMapperProfiles
{
    public class OnBilgilendirmeProfile : Profile
    {
        public OnBilgilendirmeProfile()
        {
            CreateMap<OnBilgilendirme, OnBilgilendirmeDTO>().ReverseMap();
        }
    }
}
