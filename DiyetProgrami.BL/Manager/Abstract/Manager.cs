using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using DiyetProgrami.DAL.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DiyetProgrami.BL.Manager.Abstract
{
    public abstract class Manager<TModel, TEntity, TMapperProfile> : IManager<TModel> where TMapperProfile : Profile, new()
    {

        private IMapper _mapper;


        protected IRepository<TEntity> _repository;
        private MapperConfiguration _config;
        public Manager()
        {

            _config = new MapperConfiguration(cfg =>
            {

                cfg.AddExpressionMapping().CreateMap<TModel, TEntity>().ReverseMap();

                cfg.AddProfile<TMapperProfile>();

            });
            _mapper = new Mapper(_config);
        }
        public void Delete(TModel model)
        { 
            TEntity entity = _mapper.Map<TEntity>(model);

            _repository.Delete(entity);
        }

        public List<TModel> GetAll()
        {
            
            List<TEntity> entities = _repository.GetAll().ToList();

            List<TModel> models = _mapper.Map<List<TModel>>(entities);

            return models;
        }

        public List<TModel> GetAllWithInclude()
        {
            
            List<TEntity> entities = _repository.GetAllWithInclude().ToList();

            List<TModel> models = _mapper.Map<List<TModel>>(entities);

            return models;
        }

        public List<TModel> GetAllWithIncludes(params string[] navigationProperties)
        {
           
            List<TEntity> entities = _repository.GetAllWithIncludes(navigationProperties).ToList();

            List<TModel> models = _mapper.Map<List<TModel>>(entities);

            return models;
        }

        public TModel GetById(Guid id)
        {

            TEntity entity = _repository.GetById(id);

            TModel model = _mapper.Map<TModel>(entity);

            return model;
        }

        public void Insert(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);

            _repository.Insert(entity);
        }

        public void Remove(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);

            _repository.Remove(entity);
        }

        public List<TModel> Search(Expression<Func<TModel, bool>> predicate)
        {
            
            Expression<Func<TEntity, bool>> entityPredicate = _mapper.Map<Expression<Func<TEntity, bool>>>(predicate);

            List<TEntity> entities = _repository.Search(entityPredicate).ToList();

            List<TModel> models = _mapper.Map<List<TModel>>(entities);

            return models;
        }

        public List<TModel> SearchWithIncludes(Expression<Func<TModel, bool>> predicate)
        {

            Expression<Func<TEntity, bool>> entityPredicate = _mapper.Map<Expression<Func<TEntity, bool>>>(predicate);

            List<TEntity> entities = _repository.SearchWithIncludes(entityPredicate).ToList();

            List<TModel> models = _mapper.Map<List<TModel>>(entities);

            return models;
        }

        public void Update(TModel model)
        {

            TEntity entity = _mapper.Map<TEntity>(model);

            _repository.Update(entity);
        }

        public TModel GetDeletedById(Guid id)
        {

            TEntity entity = _repository.GetDeletedById(id);

            TModel model = _mapper.Map<TModel>(entity);

            return model;
        }

        public List<TModel> GetAllDeleted()
        {
 
            List<TEntity> entities = _repository.GetAllDeleted().ToList();

            List<TModel> models = _mapper.Map<List<TModel>>(entities);

            return models;
        }

    }
}
