﻿using Semester_Projekt.Infrastructure.Contract.Dto.Ansat;

namespace Semester_Projekt.Pages.Ansat
{
    public class AnsatIndexViewModel
    {
        public string? AnsatName { get; set; }
        public string? AnsatType { get; set; }
        public string? AnsatTelefon { get; set; }
        public int? AnsatID { get; set; }
        public string? UserID { get; set; }
        public List<int>? KompetenceIds { get; set; }
    }

    
}
