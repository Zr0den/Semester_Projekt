using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Application.ProjektCommands
{
    public class ProjektCreateRequestDto
    {
        public int ProjektID { get; }
        public string ProjektName { get; private set; }
        public int SælgerID { get; set; }
        public int KundeID { get; set; }
    }
}