using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ads.DataAcces
{
    public interface IContext
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        void SaveOrUpdate();
        IQueryable<T> Query<T>() where T : class;
    }
}
