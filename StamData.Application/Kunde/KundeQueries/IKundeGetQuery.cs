namespace StamData.Application.Kunde.KundeQueries
{
    public interface IKundeGetQuery
    {
        KundeQueryResultDto GetKunde(int kundeId);
    }
}
