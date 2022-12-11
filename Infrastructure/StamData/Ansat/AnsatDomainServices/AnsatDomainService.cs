using Domain.StamData.Ansat.AnsatDomainServices;
using Domain.StamData.Kompetencer.KompetenceModel;
using SqlServerContext;

namespace Infrastructure.StamData.Ansat.AnsatDomainServices
{
    public class AnsatDomainService : IAnsatDomainService
    {
        private readonly ServerContext _server;

        public AnsatDomainService(ServerContext server)
        {
            _server = server;
        }
            ICollection<KompetenceEntity> IAnsatDomainService.getKompetenceEntities(List<int> kompetenceIds)
        {
            return _server.KompetenceEntities.Where(a=> kompetenceIds.Contains(a.KompetenceID)).ToList();
        }
    }
}
