using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ads.Business.Abstracts;
using Ads.Model;

namespace Ads.UI.Controllers
{
    public class PacienteController : ApiController<IPacienteBusiness>
    {
        public PacienteController(IPacienteBusiness business) : base(business)
        { 

        }

        [HttpGet]

        public HttpResponseMessage Get() {
          var message = new HttpResponseMessage(HttpStatusCode.InternalServerError);

            try
            {
                var p = new paciente();
                var rta = base.BusinessInstance.GetById(1);
                p.nombre = rta.nombre;
                p.Apellido = rta.Apellido;
                message = Request.CreateResponse<paciente>(HttpStatusCode.OK,p);
            }
            catch (Exception ex) //TODO: Change that with specific exception
            {
                message = Request.CreateResponse<Exception>(HttpStatusCode.InternalServerError, ex);
            }
            return (message);
        }

    }
}
