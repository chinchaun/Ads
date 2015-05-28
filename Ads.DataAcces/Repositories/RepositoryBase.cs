using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ads.Model;

namespace Ads.DataAcces.Repositories
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {
        private readonly IContext dbContext;

        public RepositoryBase(IContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public T GetById(int id)
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
            return dbContext.Query<T>().AsQueryable();
        }
    }
}
