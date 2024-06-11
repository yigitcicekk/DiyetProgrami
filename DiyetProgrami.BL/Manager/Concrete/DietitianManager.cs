using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using DiyetProgrami.BL.Manager.Abstract;
using DiyetProgrami.BL.MappingProfiles;
using DiyetProgrami.BL.Models;
using DiyetProgrami.DAL.Context;
using DiyetProgrami.DAL.Entities;
using DiyetProgrami.DAL.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProgrami.BL.Manager.Concrete
{
    public class DietitianManager : Manager<DietitianViewModel, Dietitian, DietitianMappingProfile>
    {
        private readonly DiyetProgramiDbContext _dbContext;
        public DietitianManager(DiyetProgramiDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }
    }
}
