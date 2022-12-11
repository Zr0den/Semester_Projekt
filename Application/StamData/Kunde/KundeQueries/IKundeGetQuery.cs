namespace Application.StamData.Kunde.KundeQueries
{
    public interface IKundeGetQuery
    {
        KundeQueryResultDto GetKunde(int kundeId, string kundeUserId);
    }
}
