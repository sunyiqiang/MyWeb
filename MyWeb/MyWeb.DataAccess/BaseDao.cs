using MyWeb.Factory;
using MyWeb.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyWeb.DataAccess
{
    public class BaseDao<T> where T : class,new()
    {
        //DbContext db = DbContextFactory.GetDbContext();
        DbContext db = new DemoCodeDBEntities();
        public T Add(T entity)
        {
            entity = db.Set<T>().Add(entity);
            db.SaveChanges();
            return entity;
        }
        public bool Delete(T entity)
        {
            db.Entry<T>(entity).State = EntityState.Deleted;
            return db.SaveChanges() > 0;
        }
        public bool Update(T entity)
        {
            db.Entry<T>(entity).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }
        public IQueryable<T> Query(Expression<Func<T, bool>> whereLambda)
        {
            return db.Set<T>().Where(whereLambda);
        }
        public IQueryable<T> GetPagedList<S>(Func<T, bool> where, int pageIndex, int pageSize, out int totalCount, Expression<Func<T, S>> orderBy, bool isAsc)
        {
            var tempData = db.Set<T>().Where(where);
            totalCount = tempData.Count();
            if (isAsc)
            {
                return db.Set<T>().OrderBy(orderBy).Skip((pageIndex - 1) * pageSize).Take(pageSize);
            }
            else
            {
                return db.Set<T>().OrderByDescending(orderBy).Skip((pageIndex - 1) * pageSize).Take(pageSize);
            }
        }
    }
}
