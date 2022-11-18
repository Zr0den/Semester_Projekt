using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ansatte.Application.Queries
{
    public class AnsatQueryResultDto
    {
        public int AnsatKey { get; set; }
        public string AnsatName { get; set; }
        public string AnsatTelefon { get; set; }
        public string AnsatEmail { get; set; }
        public string AnsatType { get; set; }
        public List<string> KompetenceList { get; set; }
    }
}
