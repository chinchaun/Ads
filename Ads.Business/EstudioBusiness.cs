using Ads.Service.Contracts;
using Ads.Model;
using Ads.Business.Abstracts;

namespace Ads.Business
{
    public class EstudioBusiness : BusinessBase<IEstudioService>, IEstudioBusiness
    {
        public EstudioBusiness(IEstudioService service) : base(service) { }

        public estudio GetById(int id)
        {
            return base.ServiceInstance.GetById(id);
        }
    }
}
