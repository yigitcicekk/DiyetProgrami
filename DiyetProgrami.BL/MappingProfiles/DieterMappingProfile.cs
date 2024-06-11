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
    public class DieterMappingProfile : Profile
    {
        public DieterMappingProfile()
        {
            CreateMap<DietitianViewModel, Dietitian>().ForMember(a => a.Dieters, b => b.MapFrom(b => b.Dieters)).ReverseMap();

            CreateMap<DietPlanViewModel, DietPlan>().ForMember(a => a.Dieter, b => b.MapFrom(b => b.Dieter)).ReverseMap();
        }
    }
}
