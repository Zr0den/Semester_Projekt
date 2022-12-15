namespace Application.StamData.Kunde.KundeCommands
{
    public interface IEditKundeCommand
    {
        void EditKunde(KundeEditRequestDto requestDto);
    }
}
