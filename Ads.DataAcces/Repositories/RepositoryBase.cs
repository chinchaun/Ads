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

        public virtual T GetById(int id)
        {
            return this.dbContext.GetById<T>(id);
        }

        public virtual bool Add(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual bool SaveOrUpdate(T Entity)
        {
            throw new NotImplementedException();
        }

        public virtual bool Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual IQueryable<T> Query()
        {
            throw new NotImplementedException();
        }

        T IRepository<T>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        bool IRepository<T>.Add(T entity)
        {
            throw new NotImplementedException();
        }

        bool IRepository<T>.SaveOrUpdate(T Entity)
        {
            throw new NotImplementedException();
        }

        bool IRepository<T>.Delete(T entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<T> IRepository<T>.Query()
        {
            throw new NotImplementedException();
        }
    }
}
