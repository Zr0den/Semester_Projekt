using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Projekt.ProjektModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SqlServerContext.TypeConfiguration
{
    public class ProjektTypeConfiguration : IEntityTypeConfiguration<ProjektEntity>
    {
        public void Configure(EntityTypeBuilder<ProjektEntity> builder)
        {
            builder.ToTable("Projekt", "Projekt");
            builder.HasKey(x => x.ProjektID);

        }
    }
}
