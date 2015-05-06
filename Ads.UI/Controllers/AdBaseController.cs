using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ads.Business.Abstracts;
using Ads.Model;

namespace Ads.UI.Controllers
{
    public class AdBaseController : ApiController<IAdBaseBusiness>
    {
        public AdBaseController(IAdBaseBusiness business) : base(business)
        { 

        }

        [HttpGet]

        public HttpResponseMessage Get() {
            var message = new HttpResponseMessage(HttpStatusCode.InternalServerError);

            try
            {
                message = Request.CreateResponse<AdBase>(HttpStatusCode.OK, 
                base.BusinessInstance.GetById(1));
            }
            catch (Exception ex) //TODO: Change that with specific exception
            {
                message = Request.CreateResponse<Exception>(HttpStatusCode.InternalServerError, ex);
            }
            return (message);
        }

    }
}
