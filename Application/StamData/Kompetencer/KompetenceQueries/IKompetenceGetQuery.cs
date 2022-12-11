namespace Application.StamData.Kompetencer.KompetenceQueries
{
    public interface IKompetenceGetQuery
    {
        KompetenceQueryResultDto GetKompetence(int kompetenceId);
    }
}
