using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ads.Service.Contracts;
using Ads.Model;
using Ads.DataAcces.Repositories;

namespace Ads.Service.Implementations
{
    public abstract class BaseService<T> where T : class 
   {

        private readonly IRepository<T> Repository;

       public BaseService(IRepository<T> Repository)
       {
           this.Repository = Repository;
       }

       protected IRepository<T> RepositoryInstance
       {
           get { return Repository; }
       }

    }
}