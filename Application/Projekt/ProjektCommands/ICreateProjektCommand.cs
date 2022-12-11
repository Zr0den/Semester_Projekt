namespace Application.Projekt.ProjektCommands
{
    public interface ICreateProjektCommand
    {
        void CreateProjekt(ProjektCreateRequestDto projektCreateRequestDto);
    }
}
