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
    public class DietPlanManager : Manager<DietPlanViewModel, DietPlan, DietPlanMappingProfile>
    {

        public DietPlanManager()
        {
            _repository = new DietPlanRepository(new DAL.Context.DiyetProgramiDbContext());
        }
    }
}
