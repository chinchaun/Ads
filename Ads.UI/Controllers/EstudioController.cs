using Ads.Business.Abstracts;
using Ads.Model;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ads.Model.DTO;


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
                List<EstudioDTO> lista = new List<EstudioDTO>();
                var list = base.BusinessInstance.GetAll();
                //foreach (var estudio in list)
                //{
                //    var estudioDTO = new EstudioDTO { cod_estudio = estudio.cod_estudio, desc_estudio = estudio.desc_estudio };
                //    lista.Add(estudioDTO);
                //}

                message = Request.CreateResponse<IList<EstudioDTO>>(HttpStatusCode.OK, list);

            }
            catch (Exception ex) //TODO: Change that with specific exception
            {
                message = Request.CreateResponse<Exception>(HttpStatusCode.InternalServerError, ex);
            }
            return (message);
        }

        //public IHttpActionResult Get()
        //{
        //    IHttpActionResult result = InternalServerError();

        //    try
        //    {
        //        List<EstudioDTO> lista = new List<EstudioDTO>();
        //        var list = base.BusinessInstance.GetAll();
        //        foreach (var estudio in list)
        //        {
        //            var estudioDTO = new EstudioDTO { cod_estudio = estudio.cod_estudio, desc_estudio = estudio.desc_estudio };
        //            lista.Add(estudioDTO);
        //        }
        //        result = Ok(lista);
        //    }
        //    catch (Exception e)
        //    {
        //    }

        //    return result;
        //}

        public HttpResponseMessage GetById(int id)
        {
            var message = new HttpResponseMessage(HttpStatusCode.InternalServerError);

            try
            {
                var estudio = base.BusinessInstance.GetById(id);
                message = Request.CreateResponse<EstudioDTO>(HttpStatusCode.OK, estudio);
            }
            catch (Exception ex) //TODO: Change that with specific exception
            {
                message = Request.CreateResponse<Exception>(HttpStatusCode.InternalServerError, ex);
            }
            return (message);
        }

        [HttpPost]
        //public HttpResponseMessage Save(string cod_estudio, string desc_estudio)
        public HttpResponseMessage Save([FromBody]Model.estudio estudio)
        {
            var message = new HttpResponseMessage(HttpStatusCode.InternalServerError);

            try
            {
                base.BusinessInstance.Add(estudio);

                message = Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex) //TODO: Change that with specific exception
            {
                message = Request.CreateResponse<Exception>(HttpStatusCode.InternalServerError, ex);
            }
            return (message);
        }

        [HttpPut]
        public HttpResponseMessage Update([FromBody]Model.estudio estudio)
        {
            var message = new HttpResponseMessage(HttpStatusCode.InternalServerError);

            try
            {
                //var estudio = new Model.estudio();
                //estudio.cod_estudio = Convert.ToInt16(cod_estudio);
                //estudio.desc_estudio = desc_estudio;

                base.BusinessInstance.SaveOrUpdate(estudio);

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
