using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave.Domain.OpgaveModel
{
    public class OpgaveEntity
    {
        public int OpgaveID { get; set; }
        public string OpgaveName { get; set; }
        public string OpgaveType { get; set; }
        public int AnsatID { get; set; }

    }
}
