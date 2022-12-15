using Application.Projekt.ProjektCommands;
using Application.StamData.Ansat.AnsatCommands;
using Domain.Projekt.ProjektDomainServices;
using Domain.StamData.Ansat.AnsatDomainServices;
using Domain.StamData.Ansat.AnsatModel;
using Domain.StamData.Kompetencer.KompetenceModel;
using Domain.StamData.Kunde.KundeModel;
using SqlServerContext;

namespace Infrastructure.Projekt.ProjektDomainServices
{
    public class ProjektDomainService : IProjektDomainService
    {
        private readonly ServerContext _server;

        public ProjektDomainService(ServerContext server)
        {
            _server = server;
        }

        KundeEntity IProjektDomainService.GetKunde(int kundeId)
        {
            return _server.KundeEntities.Find(kundeId);
        }

        //AnsatEntity IProjektDomainService.GetSaelger(string userID)
        //{
        //    return _server.AnsatEntities.Find(userID);
        //}
    }
}
