using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ads.Service.Contracts;
using Ads.Model;
using Ads.DataAcces.Repositories;

namespace Ads.Service.Implementations
{
   public class AdBaseService : IAdBaseService {

        private readonly IRepository<AdBase> adbaseRepository;

        public AdBaseService(IRepository<AdBase> AdBaseRepository){
             adbaseRepository = AdBaseRepository;
        }

        public AdBase GetById(int id){
            AdBase Ad = adbaseRepository.ById(id);
            return Ad;
        }
    }
}
