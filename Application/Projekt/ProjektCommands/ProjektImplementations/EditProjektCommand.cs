using Application.Projekt.ProjektRepositories;

namespace Application.Projekt.ProjektCommands.ProjektImplementations
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
