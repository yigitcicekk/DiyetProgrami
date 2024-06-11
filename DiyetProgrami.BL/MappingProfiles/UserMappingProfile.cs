using AutoMapper;
using DiyetProgrami.BL.Models;
using DiyetProgrami.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProgrami.BL.MappingProfiles
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<UserViewModel, User>()
            .ForMember(dest => dest.Dietitian, opt => opt.MapFrom(src => src.Dietitian))
            .ForMember(dest => dest.VerificationCode, opt => opt.MapFrom(src => src.VerificationCode))
            .ForMember(dest => dest.IsVerified, opt => opt.MapFrom(src => src.IsVerified))
            .ReverseMap();
        }
    }
}
