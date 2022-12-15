using Application.StamData.Ansat.AnsatRepositories;

namespace Application.StamData.Ansat.AnsatQueries.AnsatImplementations
{
    public class AnsatGetQuery : IAnsatGetQuery
    {
        private readonly IAnsatRepository _repository;

        public AnsatGetQuery(IAnsatRepository repository)
        {
            _repository = repository;
        }

        AnsatQueryResultDto IAnsatGetQuery.GetAnsat(int ansatId, string userID)
        {
            return _repository.GetAnsat(ansatId, userID);
        }
    }
}
