using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ads.Model;
using Ads.DataTransferObject;

namespace Ads.EntityFrameWork.Mapping
{
    public class AdBaseMapping
    {
        public  AdBaseMapping() {
            Mapper.CreateMap<AdsBaseDto, AdBase>();
        }
    }
}
