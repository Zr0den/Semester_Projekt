using StamData.Application.Ansat.AnsatRepositories;
using StamData.Application.Kompetencer.KompetenceRepositories;

namespace StamData.Application.Kompetencer.KompetenceQueries.KompetenceImplementations
{
    public class KompetenceGetAllQuery : IKompetenceGetAllQuery
    {
        private readonly IKompetenceRepository _kompetenceRepository;


        public KompetenceGetAllQuery(IKompetenceRepository kompetenceRepository)
        {
            _kompetenceRepository = kompetenceRepository;
        }

        IEnumerable<KompetenceQueryResultDto> IKompetenceGetAllQuery.GetAll(int kompetenceId)
        {
            return _kompetenceRepository.GetAll(kompetenceId);
        }
    }
}
