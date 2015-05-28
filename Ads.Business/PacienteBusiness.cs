using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ads.Service.Contracts;
using Ads.Model;
using Ads.Business.Abstracts;

namespace Ads.Business
{
    public class PacienteBusiness : BusinessBase<IPacienteService>, IPacienteBusiness
   {
       public PacienteBusiness(IPacienteService service) : base(service) { }

       public paciente  GetById(int id){
           return base.ServiceInstance.GetById(id);
       }
   }
}
