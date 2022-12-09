using Microsoft.EntityFrameworkCore;
using SqlServerContext;
using StamData.Domain.Ansat.AnsatDomainServices;
using StamData.Domain.Kompetencer.KompetenceModel;

namespace StamData.Infrastructure.Ansat.AnsatDomainServices
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
