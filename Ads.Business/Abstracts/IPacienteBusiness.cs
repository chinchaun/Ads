using Ads.Model;
using System.Collections.Generic;
using Ads.Model.DTO;

namespace Ads.Business.Abstracts
{
    public interface IPacienteBusiness
    {
        PacienteDTO GetById(int id);
        void SaveOrUpdate(paciente paciente);
        void Add(paciente paciente);
        List<PacienteDTO> GetAll();
    }
}