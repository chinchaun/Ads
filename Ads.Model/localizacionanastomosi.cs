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
    using System;
    using System.Collections.Generic;
    
    public partial class localizacionanastomosi
    {
        public localizacionanastomosi()
        {
            this.accesovasculars = new HashSet<accesovascular>();
            this.pacientes = new HashSet<paciente>();
        }
    
        public int cod_localizacion { get; set; }
        public string descripcion { get; set; }
    
        public virtual ICollection<accesovascular> accesovasculars { get; set; }
        public virtual ICollection<paciente> pacientes { get; set; }
    }
}
