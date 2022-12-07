using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Opgave.Domain.OpgaveModel;

namespace SqlServerContext.TypeConfiguration
{
    public class OpgaveTypeConfiguration : IEntityTypeConfiguration<OpgaveEntity>
    {
        public void Configure(EntityTypeBuilder<OpgaveEntity> builder)
        {
            builder.ToTable("Opgave", "Opgave");
            builder.HasKey(x => x.OpgaveID);

        }


    }
}
