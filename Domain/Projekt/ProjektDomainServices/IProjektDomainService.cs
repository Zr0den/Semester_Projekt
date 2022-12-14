using Domain.StamData.Ansat.AnsatModel;
using Domain.StamData.Kunde.KundeModel;

namespace Domain.Projekt.ProjektDomainServices
{
    public interface IProjektDomainService
    {
        //public AnsatEntity GetSaelger(string userID);
        public KundeEntity GetKunde(int kundeId);
    }
}
