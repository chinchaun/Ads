using Ads.Service.Contracts;
using Ads.Model;
using Ads.Business.Abstracts;
using System;
using System.Collections.Generic;
using Ads.Model.DTO;


namespace Ads.Business
{
    public class EstudioBusiness : BusinessBase<IEstudioService>, IEstudioBusiness
    {
        public EstudioBusiness(IEstudioService service) : base(service) { }


        public List<EstudioDTO> GetAll()
        {
            return base.ServiceInstance.GetAll();
        }

        public EstudioDTO GetById(int id)
        {
            return base.ServiceInstance.GetById(id);
        }

        public void Add(estudio estudio)
        {
            base.ServiceInstance.Add(estudio);
        }

        public void SaveOrUpdate(estudio estudio)
        {
            base.ServiceInstance.SaveOrUpdate(estudio);
        }
    }
}
