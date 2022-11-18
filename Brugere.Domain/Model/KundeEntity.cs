using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brugere.Domain.Model
{
    public class KundeEntity
    {
        public int KundeId { get; set; }
        public string KundeName { get; set; }
        public string KundeTelefon { get; set; }
        public string KundeEmail { get; set; }
        public string KundeAdresse { get; set; }
    }
}
