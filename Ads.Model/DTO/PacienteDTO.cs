using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ads.Model.DTO
{
    public class PacienteDTO
    {
        public int cod_paciente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string NroObraSocial { get; set; }
        public string Sexo { get; set; }
    }
}
