using System.Linq;
using Ads.Service.Contracts;
using Ads.Model;
using Ads.DataAcces.Repositories;
using System;
using System.Collections.Generic;
using Ads.Model.DTO;

namespace Ads.Service.Implementations
{
    public class PacienteService : BaseService<paciente> , IPacienteService
    {

        public PacienteService(IRepository<paciente> PacienteRepository) : base(PacienteRepository)
        {
           
        }

        public PacienteDTO GetById(int id) {
            
            var paciente = base.RepositoryInstance.Query().Where(x => x.cod_paciente == id).FirstOrDefault();
            var pacienteDTO = new PacienteDTO { cod_paciente = paciente.cod_paciente, Nombre = paciente.nombre,
                Apellido = paciente.Apellido, FechaNacimiento = (DateTime)paciente.fechaNacimiento,
                NroObraSocial = paciente.nroObraSocial
            };
            return pacienteDTO;
        }

        public List<PacienteDTO> GetAll()
        {
            List<PacienteDTO> lista = new List<PacienteDTO>();
            var list = base.RepositoryInstance.Query().Where(x => x.estado == "Habilitado").ToList<paciente>();
            foreach (var paciente in list)
            {
                var pacienteDTO = new PacienteDTO
                {
                    cod_paciente = paciente.cod_paciente,
                    Nombre = paciente.nombre,
                    Apellido = paciente.Apellido,
                    FechaNacimiento = (DateTime)paciente.fechaNacimiento,
                    NroObraSocial = paciente.nroObraSocial
                };
                lista.Add(pacienteDTO);
            }
            return lista;
        }

        public void Add(paciente paciente)
        {
            base.RepositoryInstance.Add(paciente);
        }

        public void SaveOrUpdate(paciente paciente)
        {
            var entity = base.RepositoryInstance.Query().Where(x => x.cod_paciente == paciente.cod_paciente).FirstOrDefault();
            entity.nombre = paciente.nombre;
            entity.Apellido = paciente.Apellido;
            entity.nroObraSocial = paciente.nroObraSocial;
            base.RepositoryInstance.SaveOrUpdate(paciente);
        }


    }
}
