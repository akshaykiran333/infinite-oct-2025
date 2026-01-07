using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

using MVC_CodeFirst.Models;

namespace MVC_CodeFirst.Repository
{
    public class ProductRepository<T> :IProductRepository<T> where T:class

    {
        ProductContext db;
        DbSet<T> dbset;

        public ProductRepository()
        {
            db = new ProductContext();
            dbset=db.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
           return dbset.ToList();
        }
        public T GetByID(object id)
        {
            return dbset.Find(id);
        }
        public void Insert(T obj)
        {
            dbset.Add(obj);
        }
        public void Update(T obj)
        {
            db.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(T entity)

        {

            if (db.Entry(entity).State == EntityState.Detached)

            {

                dbset.Attach(entity);

            }

            dbset.Remove(entity);

        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}