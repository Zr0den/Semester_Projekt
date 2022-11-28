using StamData.Application.Ansat.AnsatQueries;
using StamData.Domain.Ansat.AnsatModel;

namespace StamData.Application.Ansat.AnsatRepositories
{
    public interface IAnsatRepository
    {
        void Add(AnsatEntity ansat);
        IEnumerable<AnsatQueryResultDto> GetAll(string userId);
        AnsatQueryResultDto Get(int ansatId, string userId);
        AnsatEntity Load(int ansatId, string userId);
        void Update(AnsatEntity model);
    }
}
