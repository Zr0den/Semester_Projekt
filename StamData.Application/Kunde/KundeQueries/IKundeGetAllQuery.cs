namespace StamData.Application.Kunde.KundeQueries
{
    public interface IKundeGetAllQuery
    {
        IEnumerable<KundeQueryResultDto> GetAllKunde(string kundeUserId);
    }
}
