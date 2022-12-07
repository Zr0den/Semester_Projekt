using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opgave.Application.OpgaveQueries;
using Opgave.Domain.OpgaveModel;

namespace Opgave.Application.OpgaveRepositories
{
    public interface IOpgaveRepository
    {
        void AddOpgave(OpgaveEntity opgave);
        IEnumerable<OpgaveQueryResultDto> GetAllOpgave();
        OpgaveQueryResultDto GetOpgave(int opgaveId);
        OpgaveEntity LoadOpgave(int opgaveId);
        void UpdateOpgave(OpgaveEntity model);
    }
}
