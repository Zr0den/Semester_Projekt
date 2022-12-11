namespace Application.StamData.Kunde.KundeQueries
{
    public interface IKundeGetAllQuery
    {
        IEnumerable<KundeQueryResultDto> GetAllKunde(string kundeUserId);
    }
}
