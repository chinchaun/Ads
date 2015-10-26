using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ads.Model;
using Ads.Model.DTO;

namespace Ads.Service.Contracts
{
    public interface IPacienteService
    {
        PacienteDTO GetById(int id);
        List<PacienteDTO> GetAll();
        void Add(paciente paciente);
        void SaveOrUpdate(paciente paciente);
    }
}
