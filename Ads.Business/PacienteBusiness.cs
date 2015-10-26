using Ads.Service.Contracts;
using Ads.Model;
using Ads.Business.Abstracts;
using System;
using System.Collections.Generic;
using Ads.Model.DTO;

namespace Ads.Business
{
    public class PacienteBusiness : BusinessBase<IPacienteService>, IPacienteBusiness
   {
       public PacienteBusiness(IPacienteService service) : base(service) { }

        public void Add(paciente paciente)
        {
            paciente.sexo = "Femenino";
            base.ServiceInstance.Add(paciente);
        }

        public List<PacienteDTO> GetAll()
        {
            return base.ServiceInstance.GetAll();
        }

        public PacienteDTO GetById(int id){
           return base.ServiceInstance.GetById(id);
       }

        public void SaveOrUpdate(paciente paciente)
        {
            base.ServiceInstance.SaveOrUpdate(paciente);
        }
    }
}
