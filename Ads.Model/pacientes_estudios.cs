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
    
    public partial class pacientes_estudios
    {
        public int cod_estudio { get; set; }
        public int cod_paciente { get; set; }
        public System.DateTime fecha { get; set; }
        public string resultado { get; set; }
    
        public virtual estudio estudio { get; set; }
        public virtual paciente paciente { get; set; }
    }
}
