﻿using Domain.StamData.Ansat.AnsatModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace SqlServerContext.TypeConfiguration
{
    public class AnsatTypeConfiguration : IEntityTypeConfiguration<AnsatEntity>
    {
        public void Configure(EntityTypeBuilder<AnsatEntity> builder)
        {
            builder.ToTable("Ansat", "Ansat");
            builder.HasKey(x => x.AnsatID);

        }
    }
}
