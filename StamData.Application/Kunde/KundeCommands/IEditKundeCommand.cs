namespace StamData.Application.Kunde.KundeCommands
{
    public interface IEditKundeCommand
    {
        void EditKunde(KundeEditRequestDto requestDto);
    }
}
