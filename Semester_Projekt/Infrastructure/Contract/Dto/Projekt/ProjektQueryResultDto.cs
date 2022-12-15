using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester_Projekt.Infrastructure.Contract.Dto.Projekt
{
    public class ProjektQueryResultDto
    {
        public int ProjektID { get; set; }
        public string ProjektName { get; set; }
        public string UserID { get; set; }
        public int KundeID { get; set; }
        public DateTime OprettelsesDato { get; set; }
        public DateTime EstimeretSlutDato { get; set; }
    }
}
