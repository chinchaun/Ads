using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ads.Model;

namespace Ads.DataAcces.Repositories
{
    public class AdBaseRepository : RepositoryBase<AdBase>
    {
        public AdBaseRepository(IContext context)
            : base(context) { }
    }
}
