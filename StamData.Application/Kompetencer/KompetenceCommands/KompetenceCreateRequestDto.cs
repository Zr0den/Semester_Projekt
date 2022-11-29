﻿using StamData.Domain.Ansat.AnsatModel;

namespace StamData.Application.Kompetencer.KompetenceCommands
{
    public class KompetenceCreateRequestDto
    {
        public string KompetenceName { get; set; }
        public List<AnsatEntity> AnsatEntities { get; set; }
    }
}
