using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Application.ProjektRepositories;
using Projekt.Domain.ProjektModel;

namespace Projekt.Application.ProjektCommands.ProjektImplementations
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
