using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opgave.Application.OpgaveRepositories;

namespace Opgave.Application.OpgaveQueries.OpgaveImplementations
{
    public class OpgaveGetAllQuery : IOpgaveGetAllQuery
    {
        private readonly IOpgaveRepository _repository;

        public OpgaveGetAllQuery(IOpgaveRepository repository)
        {
            _repository = repository;
        }

        IEnumerable<OpgaveQueryResultDto> IOpgaveGetAllQuery.GetAllOpgave()
        {
            return _repository.GetAllOpgave();
        }
    }
}
