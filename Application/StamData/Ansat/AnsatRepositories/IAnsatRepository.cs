using Application.StamData.Ansat.AnsatQueries;
using Domain.StamData.Ansat.AnsatModel;

namespace Application.StamData.Ansat.AnsatRepositories
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
