using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using DiyetProgrami.BL.CCS;
using DiyetProgrami.BL.Manager.Abstract;
using DiyetProgrami.BL.MappingProfiles;
using DiyetProgrami.BL.Models;
using DiyetProgrami.DAL.Context;
using DiyetProgrami.DAL.Entities;
using DiyetProgrami.DAL.Repository.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProgrami.BL.Manager.Concrete
{
    public class DieterManager : Manager<DieterViewModel, Dieter, DieterMappingProfile>
    {
        private readonly DieterRepository _repository;
        private readonly IMapper _mapper;
        private readonly DiyetProgramiDbContext _dbContext;
        public DieterManager(DiyetProgramiDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _repository = new DieterRepository(dbContext);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddExpressionMapping().CreateMap<DieterViewModel, Dieter>().ReverseMap();
                cfg.AddProfile<DieterMappingProfile>();
            });
            _mapper = config.CreateMapper();
        }

        
    }
}
