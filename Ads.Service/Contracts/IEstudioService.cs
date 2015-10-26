using Ads.Model;
using System.Collections.Generic;
using Ads.Model.DTO;


namespace Ads.Service.Contracts
{
    public interface IEstudioService
    {
        EstudioDTO GetById(int id);
        void Add(estudio estudio);
        void SaveOrUpdate(estudio estudio);
        List<EstudioDTO> GetAll();
    }
}
