namespace StamData.Application.Kompetencer.KompetenceQueries
{
    public interface IKompetenceGetAllQuery
    {
        IEnumerable<KompetenceQueryResultDto> GetAllKompetence();
    }
}
