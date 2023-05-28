using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Task.data
{
    public class context:DbContext
    {

        public DbSet<user> Users { get; set; }

        public DbSet<service> Services { get; set; }
        public DbSet<interested> Interested { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.UseSqlServer("data source = localhost ; initial catalog=user; integrated security=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
