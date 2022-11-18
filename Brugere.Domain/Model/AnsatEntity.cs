using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brugere.Domain.Model
{
    public class AnsatEntity
    {
        public int AnsatId { get; set; }
        public string AnsatName { get; set; }
        public string AnsatTelefon { get; set; }
        public string AnsatEmail { get; set; }
        public string AnsatType { get; set; }
        public List<string> KompetenceList { get; set; }
    }
}
