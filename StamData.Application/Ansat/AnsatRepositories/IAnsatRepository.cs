using StamData.Application.Ansat.AnsatQueries;
using StamData.Domain.Ansat.AnsatModel;

namespace StamData.Application.Ansat.AnsatRepositories
{
    public interface IAnsatRepository
    {
        void AddAnsat(AnsatEntity ansat);
        IEnumerable<AnsatQueryResultDto> GetAllAnsat(string userId);
        AnsatQueryResultDto GetAnsat(int ansatId, string userId);
        AnsatEntity LoadAnsat(int ansatId);
        void UpdateAnsat(AnsatEntity model);
        void AddAnsatKompetence(int ansatId);
    }
}
