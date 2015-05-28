using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ads.Model;

namespace Ads.DataAcces.Repositories
{
    public class PacienteRepository : RepositoryBase<paciente>
    {
        public PacienteRepository(IContext context)
            : base(context) { }

    }
}
