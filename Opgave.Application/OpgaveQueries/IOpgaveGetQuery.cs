using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave.Application.OpgaveQueries
{
    public interface IOpgaveGetQuery
    {
        OpgaveQueryResultDto GetOpgave(int opgaveId);

    }
}
