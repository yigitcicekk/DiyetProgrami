using DiyetProgrami.DAL.Context;
using DiyetProgrami.DAL.Enum;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProgrami.DAL.Repository.Abstract
{
    public abstract class Repository<T> : IRepository<T> where T : BaseEntity, new()
    {
        private readonly DiyetProgramiDbContext _db;
        private DbSet<T> entities;

        public Repository(DiyetProgramiDbContext db)
        {
            _db = db;
            entities = _db.Set<T>();
        }


        public void Delete(T entity) 
        {
            entity.DeletedDate = DateTime.Now;
            entity.DataStatus = DataStatus.Deleted;
            // güncelleyi çağıracağız, güncelleyi çağırınca güncelle kendisi savechanges yapacak.
            Update(entity);
        }

        public IQueryable<T> GetAll()
        {
            return entities.Where(e => e.DataStatus != DataStatus.Deleted).AsNoTracking();
        }

        public IQueryable<T> GetAllWithInclude()
        {
            IQueryable<T> query = GetAll();

            // Gönderilen türe ait olan bütün navigation prop'ları include etmeli.
            // Gönderilen türün özellikleri içerisinde döngü ile gezinsek ve IEntity'den miras alanları include etsek.

            // Türü bulabilmek için (T'yi) T'den bir nesne oluşturup, özellikleri içerisinde döngü ile gezinip, IEntity'den miras alanları include edelim.

            T instance = new T(); // Gönderilenden bir örnek al
            Type type = instance.GetType(); // Türünü bul

            // Buna ait olan prop'ları elde et. Bir diziye aktarıyoruz.
            PropertyInfo[] propertyInfos = type.GetProperties();

            // Bu prop'lar içerisinde dönelim.

            foreach (PropertyInfo propInfo in propertyInfos.Where(pi => pi.PropertyType.GetInterfaces().Where(i => i.Name == "IEntity").Any()).ToList())
            {
                query = query.Include(propInfo.Name);
            }

            return query;
        }

        public IQueryable<T> GetAllWithIncludes(params string[] navigationProperties)
        {
            IQueryable<T> query = GetAll();

            // Sadece istenen navigation'ları include edecek

            // İSTENEN navigation prop'lar içerinde foreach ile dönüp include ediyoruz

            foreach (var navigationProperty in navigationProperties)
                query = query.Include(navigationProperty);

            return query;
        }

        public IQueryable<T> GetAllDeleted()
        {
            return entities.Where(e => e.DataStatus == DataStatus.Deleted).AsNoTracking();
        }


        public T GetById(Guid id)
        {
            return entities.AsNoTracking().FirstOrDefault(e => e.Id == id && e.DataStatus != DataStatus.Deleted);
        }

        public T GetDeletedById(Guid id)
        {
            return entities.AsNoTracking().FirstOrDefault(e => e.Id == id && e.DataStatus == DataStatus.Deleted);
        }

        public void Insert(T entity)
        {
            entity.DataStatus = DataStatus.Added;
            entity.CreatedDate = DateTime.Now;
            entities.Add(entity);
            _db.SaveChanges();
        }

        public void Remove(T entity)
        {
            entities.Remove(entity);
            _db.SaveChanges();
        }

        public IQueryable<T> Search(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            var all = entities.Where(e => e.DataStatus != DataStatus.Deleted);
            return all.Where(predicate);
        }

        public IQueryable<T> SearchWithIncludes(Expression<Func<T, bool>> predicate)
        {
            // önce include olmayan search'ü çağıralım sonra buna da include ekleyelim
            var all = Search(predicate);

            T instance = new T(); // Gönderilenden bir örnek al
            Type type = instance.GetType(); // Türünü bul

            // Buna ait olan prop'ları elde et. Bir diziye aktarıyoruz.
            PropertyInfo[] propertyInfos = type.GetProperties();

            // Bu prop'lar içerisinde dönelim.

            foreach (PropertyInfo propInfo in propertyInfos.Where(pi => pi.PropertyType.GetInterfaces().Where(i => i.Name == "IEntity" || i.Name == "IList").Any()).ToList())
            {
                all = all.Include(propInfo.Name);
            }

            return all;
        }

        public void Update(T entity)
        {
            entity.CreatedDate = entities.AsNoTracking().FirstOrDefault(e => e.Id == entity.Id).CreatedDate;
        
            if (entity.DataStatus != DataStatus.Deleted)
            {
                entity.DataStatus = DataStatus.Modified;
                entity.ModifiedDate = DateTime.Now;
            }

            entities.Update(entity);
            _db.SaveChanges();
        }
    }
}
