namespace StamData.Application.Ansat.AnsatQueries
{
    public interface IAnsatGetQuery
    {
        AnsatQueryResultDto GetAnsat(int ansatId, string userId);
    }
}
