namespace Application.StamData.Kunde.KundeCommands
{
    public interface ICreateKundeCommand
    {
        void CreateKunde(KundeCreateRequestDto kundeCreateRequestDto);
    }
}
