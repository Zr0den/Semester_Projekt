﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave.Domain.OpgaveModel
{
    public class OpgaveEntity
    {
        public int OpgaveID { get; }
        public string OpgaveName { get; set; }
        public string OpgaveType { get; set; }
        public int KompetenceID { get; set; }


        internal OpgaveEntity()
        {

        }

        public OpgaveEntity(string opgaveName, string opgaveType, int kompetenceId)
        {
            OpgaveName = opgaveName;
            OpgaveType = opgaveType;
            KompetenceID = kompetenceId;
        }

        public void Edit(string opgaveName, string opgaveType, int kompetenceId)
        {
            OpgaveName = opgaveName;
            OpgaveType = opgaveType;
            KompetenceID = kompetenceId;
        }
    }
}
