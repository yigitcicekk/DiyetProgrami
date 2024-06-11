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
    public class AdminMappingProfile : Profile
    {
        public AdminMappingProfile()
        {
            CreateMap<UserViewModel, User>().ForMember(a => a.Admins, b => b.MapFrom(b => b.Admins)).ReverseMap();
        }
    }
}
