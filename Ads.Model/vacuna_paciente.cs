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
    
    public partial class vacuna_paciente
    {
        public int id { get; set; }
        public int id_vacuna { get; set; }
        public int id_paciente { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string otros { get; set; }
    
        public virtual paciente paciente { get; set; }
        public virtual vacuna vacuna { get; set; }
    }
}
