using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiShopOnline.Models;

namespace WebApiShopOnline.Interface.Repository
{
    public interface IRepository<T> where T:BaseEntity
    {
        List<T> GetAll();
        T GetById(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}