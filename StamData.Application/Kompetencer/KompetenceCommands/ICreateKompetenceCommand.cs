namespace StamData.Application.Kompetencer.KompetenceCommands
{
    public interface ICreateKompetenceCommand
    {
        void CreateKompetence(KompetenceCreateRequestDto kompetenceCreateRequestDto);
    }
}
