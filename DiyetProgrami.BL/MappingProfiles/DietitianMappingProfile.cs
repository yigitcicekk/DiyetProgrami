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
    public class DietitianMappingProfile : Profile
    {
        public DietitianMappingProfile()
        {
            CreateMap<UserViewModel, User>().ForMember(a => a.Dietitians, b => b.MapFrom(b => b.Dietitians)).ReverseMap();

            CreateMap<DieterViewModel, Dieter>().ForMember(a => a.Dietitian, b => b.MapFrom(b => b.Dietitian)).ReverseMap();

            CreateMap<DietPlanViewModel, DietPlan>().ForMember(a => a.Dietitian, b => b.MapFrom(b => b.Dietitian)).ReverseMap();
        }
    }
}
