using System.Linq;

namespace Ads.DataAcces.Repositories
{
    public interface IRepository<T>
    {
        T GetById(int id);
        bool Add(T entity);
        bool SaveOrUpdate(T Entity);
        bool Delete(T entity);
        IQueryable<T> Query();
    }
}
