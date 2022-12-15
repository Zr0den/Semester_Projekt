namespace Application.Opgave.OpgaveQueries
{
    public interface IOpgaveGetAllQuery
    {
        IEnumerable<OpgaveQueryResultDto> GetAllOpgave();

    }
}
