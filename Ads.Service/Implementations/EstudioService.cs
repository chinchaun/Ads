using Ads.DataAcces.Repositories;
using Ads.Model;
using Ads.Service.Contracts;
using System.Linq;

namespace Ads.Service.Implementations
{
    public class EstudioService : BaseService<estudio> , IEstudioService
    {
        public EstudioService(IRepository<estudio> EstudioRepository) : base(EstudioRepository)
        {

        }

        public estudio GetById(int id)
        {
            return base.RepositoryInstance.Query().Where(x => x.cod_estudio == id).FirstOrDefault();
        }

    }
}
