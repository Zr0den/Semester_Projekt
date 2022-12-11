using Application.Opgave.OpgaveRepositories;
using Domain.Opgave.OpgaveModel;

namespace Application.Opgave.OpgaveCommands.OpgaveImplementations
{
    public class CreateOpgaveCommand : ICreateOpgaveCommand
    {
        private readonly IOpgaveRepository _opgaveRepository;


        public CreateOpgaveCommand(IOpgaveRepository opgaveRepository)
        {
            _opgaveRepository = opgaveRepository;
        }


        void ICreateOpgaveCommand.CreateOpgave(OpgaveCreateRequestDto opgaveCreateRequestDto)
        {
            var opgave = new OpgaveEntity(opgaveCreateRequestDto.OpgaveName, opgaveCreateRequestDto.OpgaveType,
                opgaveCreateRequestDto.KompetenceID);

            _opgaveRepository.AddOpgave(opgave);
        }
    }
}
