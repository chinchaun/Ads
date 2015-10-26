using Ads.Model;
using System.Collections.Generic;
using Ads.Model.DTO;

namespace Ads.Business.Abstracts
{
    public interface IEstudioBusiness
    {
        EstudioDTO GetById(int id);
        void SaveOrUpdate(estudio estudio);
        void Add(estudio estudio);
        List<EstudioDTO> GetAll();
    }
}
