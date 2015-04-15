﻿using System.Linq;

namespace Ads.DataAcces.Repositories
{
    public interface IRepository<T>
    {
        T ById(int id);
        bool Add(T entity);
        bool Delete(T entity);
        IQueryable<T> Query();
    }
}
