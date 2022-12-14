using Application.StamData.Ansat.AnsatQueries;
using Domain.StamData.Ansat.AnsatModel;

namespace Application.StamData.Ansat.AnsatRepositories
{
    public interface IAnsatRepository
    {
        void AddAnsat(AnsatEntity ansat);
        IEnumerable<AnsatQueryResultDto> GetAllAnsat(string userID);
        AnsatQueryResultDto GetAnsat(int ansatId, string userID);
        AnsatEntity LoadAnsat(int ansatId);
        void UpdateAnsat(AnsatEntity model);
        IEnumerable<AnsatQueryResultDto> GetAllAnsatIndex();

    }
}
