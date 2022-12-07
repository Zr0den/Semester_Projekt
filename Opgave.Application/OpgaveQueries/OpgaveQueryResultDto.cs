using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave.Application.OpgaveQueries
{
    public class OpgaveQueryResultDto
    {
        public int OpgaveID { get; set; }
        public string OpgaveName { get; set; }
        public string OpgaveType { get; set; }
        public int KompetenceID { get; set; }
    }
}
