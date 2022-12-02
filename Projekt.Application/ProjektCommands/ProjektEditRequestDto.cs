using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Application.ProjektCommands
{
    public class ProjektEditRequestDto
    {
        public int ProjektID { get; set; }
        public string ProjektName { get; private set; }
        public DateTime EstimeretSlutDato { get; set; }
    }
}
