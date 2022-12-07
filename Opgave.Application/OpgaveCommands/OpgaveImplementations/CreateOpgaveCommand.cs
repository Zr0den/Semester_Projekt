using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opgave.Application.OpgaveRepositories;
using Opgave.Domain.OpgaveModel;

namespace Opgave.Application.OpgaveCommands.OpgaveImplementations
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
