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
    public class MealLogMappingProfile : Profile
    {
        public MealLogMappingProfile()
        {
            CreateMap<DietPlanViewModel, DietPlan>().ForMember(a => a.MealLog, b => b.MapFrom(b => b.MealLog)).ReverseMap(); 
        }
    }
}
