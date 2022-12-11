using Application.Opgave.OpgaveRepositories;

namespace Application.Opgave.OpgaveCommands.OpgaveImplementations
{
    public class EditOpgaveCommand : IEditOpgaveCommand
    {
        private readonly IOpgaveRepository _repository;

        public EditOpgaveCommand(IOpgaveRepository repository)
        {
            _repository = repository;
        }


        void IEditOpgaveCommand.EditOpgave(OpgaveEditRequestDto requestDto)
        {
            var model = _repository.LoadOpgave(requestDto.OpgaveID);

            model.Edit(requestDto.OpgaveName, requestDto.OpgaveType, requestDto.KompetenceID);

            _repository.UpdateOpgave(model);
        }
    }
}
