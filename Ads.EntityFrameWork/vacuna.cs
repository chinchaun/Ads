//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ads.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    
    public partial class vacuna
    {
        public vacuna()
        {
            this.vacuna_paciente = new HashSet<vacuna_paciente>();
        }
    
        public int id { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }
    
        public virtual ICollection<vacuna_paciente> vacuna_paciente { get; set; }
    }
}
