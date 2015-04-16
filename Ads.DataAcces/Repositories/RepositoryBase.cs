using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ads.Model;

namespace Ads.DataAcces.Repositories
{
    public class RepositoryBase<T> : AdBase, IRepository<T> where T : class
    {
        private readonly IDbContext _dbContext;

        public RepositoryBase(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual T ById(int id)
        {
            throw new NotImplementedException();
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
    }
}
