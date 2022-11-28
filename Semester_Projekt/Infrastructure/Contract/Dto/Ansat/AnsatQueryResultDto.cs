﻿using StamData.Domain.Kompetencer.KompetenceModel;

namespace Semester_Projekt.Infrastructure.Contract.Dto.Ansat
{
    public class AnsatQueryResultDto
    {
        public int AnsatID { get; set; }
        public string AnsatName { get; set; }
        public string AnsatTelefon { get; set; }
        public string AnsatType { get; set; }
        public string UserId { get; set; }
        public virtual ICollection<KompetenceEntity> Kompetencer { get; set; }
    }
}
