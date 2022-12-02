namespace StamData.Application.Kunde.KundeCommands
{
    public interface ICreateKundeCommand
    {
        void CreateKunde(KundeCreateRequestDto kundeCreateRequestDto);
    }
}
