using Microsoft.EntityFrameworkCore;
using Projekt.Domain.ProjektModel;
using SqlServerContext.TypeConfiguration;
using StamData.Domain.Ansat.AnsatModel;
using StamData.Domain.Kompetencer.KompetenceModel;

namespace SqlServerContext
{
    public class ServerContext : DbContext
    {
        public ServerContext(DbContextOptions<ServerContext> options) : base(options)
        {

        }
        public DbSet<KompetenceEntity> Kompetencer { get; set; }
        public DbSet<AnsatEntity> AnsatEntities { get; set; }
        public DbSet<ProjektEntity> ProjektEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<KompetenceEntity>().Ignore(e => e.AnsatEntities).ToTable("Kompetence");
            builder.Entity<AnsatEntity>().Ignore(e => e.KompetenceEntities).ToTable("Ansat");

            builder.ApplyConfiguration(new AnsatTypeConfiguration());
            builder.ApplyConfiguration(new KompetenceTypeConfiguration());
        }
    }
}
