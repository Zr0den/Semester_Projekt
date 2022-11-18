using Microsoft.EntityFrameworkCore;
using SqlServerContext.TypeConfiguration;
using StamData.Domain.Ansat.AnsatModel;

namespace SqlServerContext
{
    public class ServerContext : DbContext
    {
        public ServerContext(DbContextOptions<ServerContext> options) : base(options)
        {

        }

        public DbSet<AnsatEntity> AnsatEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AnsatTypeConfiguration());
            builder.ApplyConfiguration(new KompetenceTypeConfiguration());
        }
    }
}
