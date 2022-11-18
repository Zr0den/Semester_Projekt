using StamData.Application.Ansat.AnsatQueries;
using StamData.Domain.Ansat.AnsatModel;

namespace StamData.Application.Ansat.AnsatRepositories
{
    public interface IAnsatRepository
    {
        void Add(AnsatEntity ansat);
        IEnumerable<AnsatQueryResultDto> GetAll(string ansatId);
        AnsatQueryResultDto Get(int ansatKey, string ansatId);
    }
}
