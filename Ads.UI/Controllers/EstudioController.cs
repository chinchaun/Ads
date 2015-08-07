using Ads.Business.Abstracts;
using Ads.Model;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;

namespace Ads.UI.Controllers
{
    public class EstudioController : ApiController<IEstudioBusiness>
    {
        public EstudioController(IEstudioBusiness business) : base(business)
        {

        }

        public HttpResponseMessage Get()
        {
            var message = new HttpResponseMessage(HttpStatusCode.InternalServerError);

            try
            {
                var estudiosList = new List<estudio>();
                var estudio = new estudio();
                var rta = base.BusinessInstance.GetById(1);
                estudio.cod_estudio = rta.cod_estudio;
                estudio.desc_estudio = rta.desc_estudio;
                estudio.estado_estudio = rta.estado_estudio;
     
                estudiosList.Add(estudio);

                message = Request.CreateResponse<List<estudio>>(HttpStatusCode.OK, estudiosList);
            }
            catch (Exception ex) //TODO: Change that with specific exception
            {
                message = Request.CreateResponse<Exception>(HttpStatusCode.InternalServerError, ex);
            }
            return (message);
        }

    }
}
