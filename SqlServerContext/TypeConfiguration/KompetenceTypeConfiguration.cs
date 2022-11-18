using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StamData.Domain.Ansat.AnsatModel;
using StamData.Domain.Kompetencer.KompetenceModel;

namespace SqlServerContext.TypeConfiguration
{
    public class KompetenceTypeConfiguration : IEntityTypeConfiguration<KompetenceEntity>
    {
        public void Configure(EntityTypeBuilder<KompetenceEntity> builder)
        {
            builder.ToTable("Kompetance", "Kompetence");
            builder.HasKey(x => x.KompetenceKey);

        }


    }
}
