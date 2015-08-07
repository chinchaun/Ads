using Ads.Model;

namespace Ads.Business.Abstracts
{
    public interface IPacienteBusiness
    {
        paciente GetById(int id);
    }
}