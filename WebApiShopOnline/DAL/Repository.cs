using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApiShopOnline.Interface.Repository;
using WebApiShopOnline.Models;

namespace WebApiShopOnline.DAL
{
    public class Repository<T>:IRepository<T> where T:BaseEntity
    {
        protected readonly SchoolContext _schoolContext;
        private DbSet<T> entities;
        public Repository(SchoolContext context)
        {
            _schoolContext = context;
            entities = context.Set<T>();
        }

        public void Delete(int id)
        {
            T entity = entities.SingleOrDefault(s => s.Id == id);
            entities.Remove(entity);
        }

        public List<T> GetAll()
        {
            return entities.ToList();
        }

        public void Insert(T entity)
        {
            if (entity == null) throw new ArgumentException("entity");
            entities.Add(entity);
        }

        public void Update(T entity)
        {
            if (entity == null) throw new ArgumentException("entity");
            _schoolContext.Entry(entity).State = EntityState.Modified;
        }

        T IRepository<T>.GetById(int id)
        {
            return entities.AsNoTracking().SingleOrDefault(s => s.Id == id);
        }
    }
}