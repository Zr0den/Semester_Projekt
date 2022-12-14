using Application.StamData.Ansat.AnsatRepositories;

namespace Application.StamData.Ansat.AnsatQueries.AnsatImplementations
{
    public class AnsatGetAllQuery : IAnsatGetAllQuery
    {
        private readonly IAnsatRepository _repository;

        public AnsatGetAllQuery(IAnsatRepository repository)
        {
            _repository = repository;
        }

        IEnumerable<AnsatQueryResultDto> IAnsatGetAllQuery.GetAllAnsat(string userID)
        {
            return _repository.GetAllAnsat(userID);
        }
        IEnumerable<AnsatQueryResultDto> IAnsatGetAllQuery.GetAllAnsatIndex()
        {
            return _repository.GetAllAnsatIndex();
        }
    }
}
