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
        public DateTime EstSlutDato { get; set; }
        public virtual ICollection<OpgaveEntity> Opgaver { get; private set; }

        internal ProjektEntity()
        {

        }

        public ProjektEntity(
            string projektName, 
            ICollection<OpgaveEntity> opgaver)
        {
            this.Opgaver = new HashSet<OpgaveEntity>();
            ProjektName = projektName;
        }

        public void Edit(string projektName, ICollection<OpgaveEntity> Opgaver)
        {
            ProjektName = projektName;
            Opgaver = opgaver;
        }
    }
}
