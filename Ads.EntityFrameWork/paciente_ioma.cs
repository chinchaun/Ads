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
    
    public partial class paciente_ioma
    {
        public int nroreg { get; set; }
        public int cod_paciente { get; set; }
        public System.DateTime fecha { get; set; }
        public int presentacion { get; set; }
        public string internaciones { get; set; }
        public string complicaciones { get; set; }
        public string tranfuciones { get; set; }
        public string accesovascular { get; set; }
        public string serologia { get; set; }
        public string cirugias { get; set; }
        public string medicacion { get; set; }
        public string estadoactual { get; set; }
        public string pesoSeco { get; set; }
    
        public virtual paciente paciente { get; set; }
    }
}
