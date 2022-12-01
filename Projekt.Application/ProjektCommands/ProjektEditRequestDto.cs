using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Application.ProjektCommands
{
    public class ProjektEditRequestDto
    {

        public string ProjektName { get; private set; }
        public DateTime EstimeretSlutDato { get; set; }
        public DateTime SidstÆndret = DateTime.Now; 
    }
}
