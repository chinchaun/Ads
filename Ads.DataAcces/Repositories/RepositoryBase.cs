using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ads.DataAcces.Repositories
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {

        public T ById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Add(T entity)
        {
            throw new NotImplementedException();
        }

        public bool SaveOrUpdate(T Entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Query()
        {
            throw new NotImplementedException();
        }
    }
}
