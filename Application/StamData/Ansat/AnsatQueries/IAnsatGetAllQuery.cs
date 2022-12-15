namespace Application.StamData.Ansat.AnsatQueries
{
    public interface IAnsatGetAllQuery
    {
        IEnumerable<AnsatQueryResultDto> GetAllAnsat(string UserID);
        IEnumerable<AnsatQueryResultDto> GetAllAnsatIndex();
        IEnumerable<AnsatQueryResultDto> GetAllAnsatDerKanLaveOpgaven(int opgaveId);


    }
}
