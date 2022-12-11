namespace Application.Opgave.OpgaveQueries
{
    public interface IOpgaveGetQuery
    {
        OpgaveQueryResultDto GetOpgave(int opgaveId);

    }
}
