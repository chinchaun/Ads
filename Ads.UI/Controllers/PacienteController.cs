using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ads.Business.Abstracts;
using Ads.Model;
using System.Collections.Generic;
using Ads.Model.DTO;

namespace Ads.UI.Controllers
{
    public class PacienteController : ApiController<IPacienteBusiness>
    {
        public PacienteController(IPacienteBusiness business) : base(business)
        { 

        }

        public HttpResponseMessage Get() {
          var message = new HttpResponseMessage(HttpStatusCode.InternalServerError);

            try
            {
                var pacientesList = base.BusinessInstance.GetAll();
                message = Request.CreateResponse<IList<PacienteDTO>>(HttpStatusCode.OK, pacientesList);
            }
            catch (Exception ex) //TODO: Change that with specific exception
            {
                message = Request.CreateResponse<Exception>(HttpStatusCode.InternalServerError, ex);
            }
            return (message);
        }

        public HttpResponseMessage GetById(int id)
        {
            var message = new HttpResponseMessage(HttpStatusCode.InternalServerError);

            try
            {
                var paciente = base.BusinessInstance.GetById(id);
                message = Request.CreateResponse<PacienteDTO>(HttpStatusCode.OK, paciente);
            }
            catch (Exception ex) //TODO: Change that with specific exception
            {
                message = Request.CreateResponse<Exception>(HttpStatusCode.InternalServerError, ex);
            }
            return (message);
        }

        [HttpPost]
        public HttpResponseMessage Save([FromBody]Model.paciente paciente)
        {
            var message = new HttpResponseMessage(HttpStatusCode.InternalServerError);

            try
            {
                base.BusinessInstance.Add(paciente);

                message = Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex) //TODO: Change that with specific exception
            {
                message = Request.CreateResponse<Exception>(HttpStatusCode.InternalServerError, ex);
            }
            return (message);
        }

        [HttpPut]
        public HttpResponseMessage Update([FromBody]Model.paciente paciente)
        {
            var message = new HttpResponseMessage(HttpStatusCode.InternalServerError);

            try
            {
                base.BusinessInstance.SaveOrUpdate(paciente);

                message = Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex) //TODO: Change that with specific exception
            {
                message = Request.CreateResponse<Exception>(HttpStatusCode.InternalServerError, ex);
            }
            return (message);
        }

    }
}
