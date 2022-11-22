namespace StamData.Application.Ansat.AnsatQueries
{
    public interface IAnsatGetQuery
    {
        AnsatQueryResultDto Get(int ansatId, string userId);
    }
}
