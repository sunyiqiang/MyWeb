using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyWeb.IDataAccess
{
    public interface IBaseDao<T> where T : class, new()
    {
        T Add(T entity);
        bool Delete(T entity);
        IQueryable<T> Query(Expression<Func<T, bool>> whereLambda);
        bool Update(T entity);
        IQueryable<T> GetPagedList<S>(Func<T, bool> where, int pageIndex, int pageSize, out int totalCount, Expression<Func<T, S>> orderBy, bool isAsc);
    }
}
