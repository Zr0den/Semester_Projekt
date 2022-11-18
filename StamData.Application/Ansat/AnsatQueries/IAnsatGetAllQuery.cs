namespace StamData.Application.Ansat.AnsatQueries
{
    public interface IAnsatGetAllQuery
    {
        IEnumerable<AnsatQueryResultDto> GetAll(string ansatId);
    }
}
