using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProgrami.BL.Manager.Abstract
{
    public interface IManager<TModel>
    {
      

        public void Insert(TModel model);

        public void Update(TModel model);

        
        public void Delete(TModel model);

       
        public void Remove(TModel model);

        public List<TModel> GetAll();

        public List<TModel> GetAllWithInclude();

        public List<TModel> GetAllWithIncludes(params string[] navigationProperties);


        public List<TModel> GetAllDeleted();

        public TModel GetById(Guid id);

        public TModel GetDeletedById(Guid id);

        public List<TModel> Search(Expression<Func<TModel, bool>> predicate);

        public List<TModel> SearchWithIncludes(Expression<Func<TModel, bool>> predicate);
    }
}
