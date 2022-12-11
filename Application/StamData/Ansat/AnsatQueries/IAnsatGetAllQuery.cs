namespace Application.StamData.Ansat.AnsatQueries
{
    public interface IAnsatGetAllQuery
    {
        IEnumerable<AnsatQueryResultDto> GetAllAnsat(string userId);
    }
}
