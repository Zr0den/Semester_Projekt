using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Domain.ProjektModel
{
    public class ProjektEntity
    {
        public int ProjektID { get; }
        public string ProjektName { get; private set; }
        public int SælgerID { get; set; }
        public int KundeID { get; set; }
        public DateTime OprettelsesDato { get; set; }
        public DateTime EstimeretSlutDato { get; set; }
        //public virtual ICollection<OpgaveEntity> Opgaver { get; private set; }

        internal ProjektEntity()
        {

        }

        public ProjektEntity(
            string projektName, int sælgerId, int kundeId)
        {
            ProjektName = projektName;
            SælgerID = sælgerId;
            KundeID = kundeId;
            OprettelsesDato = DateTime.Now;
        }
        
        public void Edit(string projektName, DateTime estSlutDato)
        {
            ProjektName = projektName;
            EstimeretSlutDato = estSlutDato;
        }
    }
}
