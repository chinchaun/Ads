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
    
    public partial class paciente_pami
    {
        public int nroreg { get; set; }
        public int cod_paciente { get; set; }
        public System.DateTime fecha { get; set; }
        public string transfusiones { get; set; }
        public string estudios { get; set; }
        public string farmacologicos { get; set; }
        public string internaciones { get; set; }
        public string causa { get; set; }
        public string dias { get; set; }
        public string donde { get; set; }
        public string vascular { get; set; }
        public string semiologico_clinico { get; set; }
        public string pesoSeco { get; set; }
        public string diuresis { get; set; }
    
        public virtual paciente paciente { get; set; }
    }
}
