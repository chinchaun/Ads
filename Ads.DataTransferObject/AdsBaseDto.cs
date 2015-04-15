using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ads.DataTransferObject
{
    public class AdsBaseDto : BaseModel
    {
        public string description { get; set; }
        public DateTime creationTime { get; set; }
    }
}
