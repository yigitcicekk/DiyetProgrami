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
    public class ExerciseLogMappingProfile : Profile
    {
            public ExerciseLogMappingProfile()
            {
                CreateMap<DietPlanViewModel, DietPlan>().ForMember(a => a.ExerciseLog, b => b.MapFrom(b => b.ExerciseLog)).ReverseMap();
            }
        
    }
}
