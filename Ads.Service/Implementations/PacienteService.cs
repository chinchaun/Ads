using System.Linq;
using Ads.Service.Contracts;
using Ads.Model;
using Ads.DataAcces.Repositories;

namespace Ads.Service.Implementations
{
    public class PacienteService : BaseService<paciente> , IPacienteService
    {

        public PacienteService(IRepository<paciente> PacienteRepository) : base(PacienteRepository)
        {
           
        }

        public paciente GetById(int id) {
            return base.RepositoryInstance.Query().Where(x => x.cod_paciente == id).FirstOrDefault();
        }

    }
}
