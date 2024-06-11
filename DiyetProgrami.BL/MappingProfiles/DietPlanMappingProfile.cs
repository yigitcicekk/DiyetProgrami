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
    public class DietPlanMappingProfile : Profile
    {
        public DietPlanMappingProfile()
        {
            CreateMap<DietitianViewModel, Dietitian>().ForMember(a => a.DietPlans, b => b.MapFrom(b => b.DietPlans)).ReverseMap();

            CreateMap<DieterViewModel, Dieter>().ForMember(a => a.DietPlans, b => b.MapFrom(b => b.DietPlans)).ReverseMap();

            CreateMap<MealLogViewModel, MealLog>().ForMember(a => a.DietPlan, b => b.MapFrom(b => b.DietPlan)).ReverseMap();
            
            CreateMap<ExerciseLogViewModel, ExerciseLog>().ForMember(a => a.DietPlan, b => b.MapFrom(b => b.DietPlan)).ReverseMap();
        }
    }
}
