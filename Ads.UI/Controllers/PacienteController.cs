using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ads.Business.Abstracts;
using Ads.Model;
using System.Collections.Generic;

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
                var pacientesList = new List<paciente>();
                var paciente = new paciente();
                var rta = base.BusinessInstance.GetById(1);
                paciente.nombre = rta.nombre;
                paciente.Apellido = rta.Apellido;
                paciente.fechaNacimiento = rta.fechaNacimiento;
                paciente.nroObraSocial = rta.nroObraSocial;
                pacientesList.Add(paciente);

                message = Request.CreateResponse<List<paciente>>(HttpStatusCode.OK, pacientesList);
            }
            catch (Exception ex) //TODO: Change that with specific exception
            {
                message = Request.CreateResponse<Exception>(HttpStatusCode.InternalServerError, ex);
            }
            return (message);
        }

    }
}
