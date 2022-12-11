namespace Application.StamData.Ansat.AnsatQueries
{
    public interface IAnsatGetQuery
    {
        AnsatQueryResultDto GetAnsat(int ansatId, string userId);
    }
}
