﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StamData.Domain.Ansat.AnsatModel;
using StamData.Domain.Kunde.KundeModel;

namespace Projekt.Domain.ProjektModel
{
    public class ProjektEntity
    {
        public int ProjektID { get; }
        public string ProjektName { get; private set; }
        public DateTime OprettelsesDato { get; set; }
        public DateTime EstimeretSlutDato { get; set; }
      
        
        public int SælgerID { get; set; }
        public AnsatEntity AnsatEntity { get; set; }
        public int KundeID { get; set; }
        public KundeEntity KundeEntity { get; set; }

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
        
        public void Edit(string projektName)
        {
            ProjektName = projektName;
        }
    }
}
