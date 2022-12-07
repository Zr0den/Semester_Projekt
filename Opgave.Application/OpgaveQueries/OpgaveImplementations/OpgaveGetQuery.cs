using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opgave.Application.OpgaveRepositories;

namespace Opgave.Application.OpgaveQueries.OpgaveImplementations
{
    public class OpgaveGetQuery : IOpgaveGetQuery
    {
        private readonly IOpgaveRepository _repository;

        public OpgaveGetQuery(IOpgaveRepository repository)
        {
            _repository = repository;
        }

        OpgaveQueryResultDto IOpgaveGetQuery.GetOpgave(int opgaveId)
        {
            return _repository.GetOpgave(opgaveId);
        }
    }
}
