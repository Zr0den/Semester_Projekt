using Microsoft.EntityFrameworkCore;
using Projekt.Domain.ProjektModel;
using SqlServerContext.TypeConfiguration;
using StamData.Domain.Ansat.AnsatModel;
using StamData.Domain.Kompetencer.KompetenceModel;
using StamData.Domain.Kunde.KundeModel;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace SqlServerContext
{
    public class ServerContext : DbContext
    {
        public ServerContext(DbContextOptions<ServerContext> options) : base(options)
        {

        }
        public DbSet<KompetenceEntity> KompetenceEntities { get; set; }
        public DbSet<AnsatEntity> AnsatEntities { get; set; }
        public DbSet<ProjektEntity> ProjektEntities { get; set; }
        public DbSet<KundeEntity> KundeEntities { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfiguration(new AnsatTypeConfiguration());
            builder.ApplyConfiguration(new KompetenceTypeConfiguration());
            builder.ApplyConfiguration(new ProjektTypeConfiguration());
            builder.ApplyConfiguration(new KundeTypeConfiguration());

            
        }

    }
}
