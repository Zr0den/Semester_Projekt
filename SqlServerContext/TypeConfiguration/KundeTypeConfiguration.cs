using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.StamData.Kunde.KundeModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SqlServerContext.TypeConfiguration
{
    public class KundeTypeConfiguration : IEntityTypeConfiguration<KundeEntity>
    {
        public void Configure(EntityTypeBuilder<KundeEntity> builder)
        {
            builder.ToTable("Kunde", "Kunde");
            builder.HasKey(x => x.KundeID);
        }
    }
}
