﻿using DiyetProgrami.DAL.Context;
using DiyetProgrami.DAL.Entities;
using DiyetProgrami.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProgrami.DAL.Repository.Concrete
{
    public class MealLogRepository : Repository<MealLog>
    {
        public MealLogRepository(DiyetProgramiDbContext db) : base(db)
        {

        }
    }
}
