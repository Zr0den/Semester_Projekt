namespace Application.StamData.Kompetencer.KompetenceQueries
{
    public interface IKompetenceGetAllQuery
    {
        IEnumerable<KompetenceQueryResultDto> GetAllKompetence();
    }
}
