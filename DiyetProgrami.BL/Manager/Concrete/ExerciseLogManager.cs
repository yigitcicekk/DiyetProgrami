using DiyetProgrami.BL.Manager.Abstract;
using DiyetProgrami.BL.MappingProfiles;
using DiyetProgrami.BL.Models;
using DiyetProgrami.DAL.Entities;
using DiyetProgrami.DAL.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProgrami.BL.Manager.Concrete
{
    public class ExerciseLogManager : Manager<ExerciseLogViewModel, ExerciseLog, ExerciseLogMappingProfile>
    {

        public ExerciseLogManager()
        {
            _repository = new ExerciseLogRepository(new DAL.Context.DiyetProgramiDbContext());

        }
    }
}
