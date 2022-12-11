using Application.Projekt.ProjektRepositories;
using Domain.Projekt.ProjektModel;

namespace Application.Projekt.ProjektCommands.ProjektImplementations
{
    public class CreateProjektCommand : ICreateProjektCommand
    {
        private readonly IProjektRepository _projektRepository;


        public CreateProjektCommand(IProjektRepository projektRepository)
        {
            _projektRepository = projektRepository;
        }


        void ICreateProjektCommand.CreateProjekt(ProjektCreateRequestDto projektCreateRequestDto)
        {
            var projekt = new ProjektEntity(projektCreateRequestDto.ProjektName, projektCreateRequestDto.SælgerID, projektCreateRequestDto.KundeID);

            _projektRepository.AddProjekt(projekt);
        }
    }
}
