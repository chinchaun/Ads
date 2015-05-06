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
   public class AdBaseBusiness : BusinessBase<IAdBaseService>, IAdBaseBusiness
   {
       public AdBaseBusiness(IAdBaseService service) : base(service) { }

       public AdBase GetById(int id){
           return base.ServiceInstance.GetById(id);
       }
   }
}
