namespace Application.Opgave.OpgaveCommands
{
    public interface IEditOpgaveCommand
    {
        void EditOpgave(OpgaveEditRequestDto opgaveEditRequestDto);
    }
}
