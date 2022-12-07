using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Application.ProjektRepositories;

namespace Projekt.Application.ProjektCommands.ProjektImplementations
{
    public class EditProjektCommand : IEditProjektCommand
    {
        private readonly IProjektRepository _repository;

        public EditProjektCommand(IProjektRepository repository)
        {
            _repository = repository;
        }


        void IEditProjektCommand.EditProjekt(ProjektEditRequestDto requestDto)
        {
            var model = _repository.LoadProjekt(requestDto.ProjektID);

            model.Edit(requestDto.ProjektName);

            _repository.UpdateProjekt(model);
        }
    }
}
