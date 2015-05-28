using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ads.Model;
using System.Data.Entity.ModelConfiguration;

namespace Ads.EntityFrameWork.Mapping
{
    public class AdBaseMapping : EntityTypeConfiguration<Base>
    {
        //public AdBaseMapping() {
        //    Mapper.CreateMap<AdsBaseDto, Base>();
        //}
    }
}
