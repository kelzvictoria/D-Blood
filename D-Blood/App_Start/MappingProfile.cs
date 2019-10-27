using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using D_Blood.Models;
using D_Blood.Dtos;
using D_Blood.App_Start;

namespace D_Blood.App_Start
{
    public class MappingProfile : Profile
    {
       public MappingProfile()
        {
           
            Mapper.CreateMap<RegisterDonor, RegisterDonorDto>();
            Mapper.CreateMap<RegisterDonorDto, RegisterDonor>().ForMember(m => m.Id, opt => opt.Ignore());
        }
    }
}