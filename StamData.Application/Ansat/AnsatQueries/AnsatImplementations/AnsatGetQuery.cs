using StamData.Application.Ansat.AnsatRepositories;

namespace StamData.Application.Ansat.AnsatQueries.AnsatImplementations
{
    public class AnsatGetQuery : IAnsatGetQuery
    {
        private readonly IAnsatRepository _repository;

        public AnsatGetQuery(IAnsatRepository repository)
        {
            _repository = repository;
        }

        AnsatQueryResultDto IAnsatGetQuery.GetAnsat(int ansatId)
        {
            return _repository.GetAnsat(ansatId);
        }
    }
}
