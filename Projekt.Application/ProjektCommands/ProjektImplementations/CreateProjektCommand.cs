using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Application.ProjektCommands.ProjektImplementations
{
    public class CreateProjektCommand : ICreateProjektCommand
    {
        private readonly IProjektRepository _projektRepository;


        public CreateProjektCommand(IProjektRepository projektRepository)
        {
            _projektRepository = projektRepository;
        }

        void ICreateProjektCommand.Create(ProjektCreateRequestDto ProjektCreateRequestDto)
        {
            var projekt = new ProjektEntity(projektCreateRequestDto.UserId);

            _projektRepository.Add(projekt);
        }
    }
}
