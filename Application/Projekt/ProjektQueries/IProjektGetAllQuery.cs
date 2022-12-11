namespace Application.Projekt.ProjektQueries
{
    public interface IProjektGetAllQuery
    {
        IEnumerable<ProjektQueryResultDto> GetAllProjekt();
    }
}
