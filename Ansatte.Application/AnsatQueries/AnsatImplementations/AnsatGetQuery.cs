using Ansatte.Application.Repositories;

namespace Ansatte.Application.Queries.Implementation
{
    public class AnsatGetQuery : IAnsatGetQuery
    {
        private readonly IAnsatRepository _repository;

        public AnsatGetQuery(IAnsatRepository repository)
        {
            _repository = repository;
        }

        AnsatQueryResultDto IAnsatGetQuery.Get(int ansatKey, string ansatId)
        {
            return _repository.Get(ansatKey, ansatId);
        }
    }
}
