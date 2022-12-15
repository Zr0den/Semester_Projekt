namespace Application.Opgave.OpgaveCommands
{
    public interface ICreateOpgaveCommand
    {
        void CreateOpgave(OpgaveCreateRequestDto opgaveCreateRequestDto);
    }
}
