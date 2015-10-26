using Ads.DataAcces.Repositories;
using Ads.Model;
using Ads.Service.Contracts;
using System.Collections.Generic;
using System.Linq;
using Ads.Model.DTO;


namespace Ads.Service.Implementations
{
    public class EstudioService : BaseService<estudio> , IEstudioService
    {
        public EstudioService(IRepository<estudio> EstudioRepository) : base(EstudioRepository)
        {

        }

        public List<EstudioDTO> GetAll()
        {
            List<EstudioDTO> lista = new List<EstudioDTO>();
            var list = base.RepositoryInstance.Query().Where(x => x.estado_estudio == 1).ToList();
            foreach (var estudio in list)
            {
                var estudioDTO = new EstudioDTO { cod_estudio = estudio.cod_estudio, desc_estudio = estudio.desc_estudio };
                lista.Add(estudioDTO);
            }
            return lista;
        }

        public EstudioDTO GetById(int id)
        {
            var estudio =  base.RepositoryInstance.Query().Where(x => x.cod_estudio == id).FirstOrDefault();
            return new EstudioDTO { cod_estudio = estudio.cod_estudio, desc_estudio = estudio.desc_estudio };
        }

        public void Add(estudio estudio)
        {
            base.RepositoryInstance.Add(estudio);
        }

        public void SaveOrUpdate(estudio estudio)
        {
            var entity = base.RepositoryInstance.Query().Where(x => x.cod_estudio == estudio.cod_estudio).FirstOrDefault();
            entity.desc_estudio = estudio.desc_estudio;
            base.RepositoryInstance.SaveOrUpdate(estudio);            
        }

    }
}
