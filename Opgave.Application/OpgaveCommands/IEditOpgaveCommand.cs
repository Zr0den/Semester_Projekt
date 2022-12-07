using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave.Application.OpgaveCommands
{
    public interface IEditOpgaveCommand
    {
        void EditOpgave(OpgaveEditRequestDto opgaveEditRequestDto);
    }
}
