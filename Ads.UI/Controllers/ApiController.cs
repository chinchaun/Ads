using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ads.UI.Controllers
{
    public abstract class ApiController<TBusiness> : ApiController where TBusiness : class
    {
        private readonly TBusiness business;

        protected ApiController(TBusiness business) 
        {
            if (business == null)
            {
                throw new ArgumentNullException("business");
            }
            else {
                this.business = business;
            }
        }

        protected TBusiness BusinessInstance
        {
            get { return this.business; }

        }

    }
}
