namespace StamData.Application.Ansat.AnsatQueries
{
    public interface IAnsatGetAllQuery
    {
        IEnumerable<AnsatQueryResultDto> GetAllAnsat(string userId);
    }
}
