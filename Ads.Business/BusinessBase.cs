using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ads.Business
{
    public abstract class BusinessBase<TService> where TService : class
    {
        private readonly TService service;

        protected BusinessBase(TService service)
        {
            if (service == null){
                throw new ArgumentNullException("The service instance is not valid");
            }

            this.service = service;
        }

        protected TService ServiceInstance
        {
            get { return service; }
        }
    }
}
