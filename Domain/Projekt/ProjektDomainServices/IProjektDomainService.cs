using Domain.StamData.Ansat.AnsatModel;
using Domain.StamData.Kunde.KundeModel;

namespace Domain.Projekt.ProjektDomainServices
{
    public interface IProjektDomainService
    {
        KundeEntity GetKunde(int kundeId);
    }
}
