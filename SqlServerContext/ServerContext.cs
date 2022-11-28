using Microsoft.EntityFrameworkCore;
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
        public DbSet<AnsatEntity> Ansatte { get; set; }
        public DbSet<KompetenceEntity> Kompetencer { get; set; }
        public DbSet<AnsatEntity> AnsatEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<AnsatEntity>().HasMany<KompetenceEntity>(s => s.Kompetencer).WithMany(c => c.Ansatte).Map(
            //    cs =>
            //    {
            //        cs.MapLeftKey("AnsatRefId");
            //        cs.MapRightKey("KompetenceRefId");
            //        cs.ToTable("AnsatKompetence");
            //    });
            builder.ApplyConfiguration(new AnsatTypeConfiguration());
            builder.ApplyConfiguration(new KompetenceTypeConfiguration());
        }
    }
}
