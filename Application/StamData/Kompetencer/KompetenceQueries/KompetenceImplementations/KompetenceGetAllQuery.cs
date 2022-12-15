using Application.StamData.Kompetencer.KompetenceRepositories;

namespace Application.StamData.Kompetencer.KompetenceQueries.KompetenceImplementations
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
