﻿namespace Semester_Projekt.Infrastructure.Contract.Dto.Kompetence
{
    public class KompetenceEditRequestDto
    {
        public int KompetenceID { get; set; }
        public string KompetenceName { get; set; }
        public byte[] RowVersion { get; set; }
        //public List<AnsatEntity> AnsatEntities { get; set; }

    }
}
