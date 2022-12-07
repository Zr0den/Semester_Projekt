using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Application.ProjektCommands
{
    public class ProjektCreateRequestDto
    {
        public string ProjektName { get; set; }
        public int SælgerID { get; set; }
        public int KundeID { get; set; }
    }
}

