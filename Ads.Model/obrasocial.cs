//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ads.Model
{
    using System.Collections.Generic;

    public partial class obrasocial
    {
        public obrasocial()
        {
            this.pacientes = new HashSet<paciente>();
        }
    
        public int id { get; set; }
        public string razonSocial { get; set; }
        public string razonSocialAbrev { get; set; }
        public bool estado { get; set; }
    
        public virtual ICollection<paciente> pacientes { get; set; }
    }
}
