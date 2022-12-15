namespace Application.StamData.Kompetencer.KompetenceCommands
{
    public interface ICreateKompetenceCommand
    {
        void CreateKompetence(KompetenceCreateRequestDto kompetenceCreateRequestDto);
    }
}
