using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ads.Model
{
    public class AdBase : BaseModel
    {
        public string description { get; set; }
        public DateTime creationTime { get; set; }
    }
}
