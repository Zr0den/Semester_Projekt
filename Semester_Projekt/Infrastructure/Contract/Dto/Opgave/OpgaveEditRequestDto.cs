﻿namespace Semester_Projekt.Infrastructure.Contract.Dto.Opgave
{
    public class OpgaveEditRequestDto
    {
        public int OpgaveID { get; set; }
        public string OpgaveName { get; set; }
        public string OpgaveType { get; set; }
        public int KompetenceID { get; set; }
    }
}
