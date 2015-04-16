using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ads.Model;
using Ads.DataTransferObject;
using System.Data.Entity.ModelConfiguration;

namespace Ads.EntityFrameWork.Mapping
{
    public class AdBaseMapping : EntityTypeConfiguration<AdBase>
    {
        public AdBaseMapping() {
            Mapper.CreateMap<AdsBaseDto, AdBase>();
        }
    }
}
