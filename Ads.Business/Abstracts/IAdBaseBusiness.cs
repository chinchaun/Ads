using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ads.Model;

namespace Ads.Business.Abstracts
{
    public interface IAdBaseBusiness
    {
        AdBase GetById(int id);
    }
}
