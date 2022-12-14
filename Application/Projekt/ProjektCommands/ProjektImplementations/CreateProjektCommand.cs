using Application.Projekt.ProjektRepositories;
using Domain.Projekt.ProjektDomainServices;
using Domain.Projekt.ProjektModel;

namespace Application.Projekt.ProjektCommands.ProjektImplementations
{
    public class CreateProjektCommand : ICreateProjektCommand

    {
    private readonly IProjektRepository _projektRepository;
    private readonly IProjektDomainService _projektDomainService;


    public CreateProjektCommand(IProjektRepository projektRepository, IProjektDomainService projektDomainService)
    {
        _projektRepository = projektRepository;
        _projektDomainService = projektDomainService;
    }


    void ICreateProjektCommand.CreateProjekt(ProjektCreateRequestDto projektCreateRequestDto)
    {
        var projekt = new ProjektEntity(projektCreateRequestDto.ProjektName, projektCreateRequestDto.UserID,
            projektCreateRequestDto.KundeID, _projektDomainService);

        _projektRepository.AddProjekt(projekt);
    }
    }
}
