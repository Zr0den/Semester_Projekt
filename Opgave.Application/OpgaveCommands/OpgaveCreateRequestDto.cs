using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave.Application.OpgaveCommands
{
    public class OpgaveCreateRequestDto
    {
        public string OpgaveName { get; set; }
        public string OpgaveType { get; set; }
        public int KompetenceID { get; set; }
    }
}
