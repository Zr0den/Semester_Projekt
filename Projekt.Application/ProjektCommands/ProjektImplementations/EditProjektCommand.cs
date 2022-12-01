using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var model = _repository.Load(requestDto.UserId);

            model.Edit();

            _repository.Update(model);
        }
    }
}
