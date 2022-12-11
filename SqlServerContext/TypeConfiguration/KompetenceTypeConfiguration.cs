using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.StamData.Kompetencer.KompetenceModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SqlServerContext.TypeConfiguration
{
    public class KompetenceTypeConfiguration : IEntityTypeConfiguration<KompetenceEntity>
    {
        public void Configure(EntityTypeBuilder<KompetenceEntity> builder)
        {
            builder.ToTable("Kompetance", "Kompetence");
            builder.HasKey(x => x.KompetenceID);

        }
    }
}
