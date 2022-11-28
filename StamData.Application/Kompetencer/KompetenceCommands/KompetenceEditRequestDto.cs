using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StamData.Domain.Ansat.AnsatModel;

namespace StamData.Application.Kompetencer.KompetenceCommands
{
    public class KompetenceEditRequestDto
    {
        public int KompetenceID { get; set; }
        public string KompetenceName { get; set; }
        public virtual ICollection<AnsatEntity> Ansatte { get; set; }
    }
}
