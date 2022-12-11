using Application.StamData.Kompetencer.KompetenceRepositories;

namespace Application.StamData.Kompetencer.KompetenceQueries.KompetenceImplementations
{
    public class KompetenceGetQuery : IKompetenceGetQuery
    {
        private readonly IKompetenceRepository _repository;

        public KompetenceGetQuery(IKompetenceRepository repository)
        {
            _repository = repository;
        }

        KompetenceQueryResultDto IKompetenceGetQuery.GetKompetence(int kompetenceId)
        {
            return _repository.GetKompetence(kompetenceId);
        }
    }
}
