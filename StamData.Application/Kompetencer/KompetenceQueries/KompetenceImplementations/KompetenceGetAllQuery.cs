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

        IEnumerable<KompetenceQueryResultDto> IKompetenceGetAllQuery.GetAllKompetence()
        {
            return _kompetenceRepository.GetAllKompetence();
        }
    }
}
