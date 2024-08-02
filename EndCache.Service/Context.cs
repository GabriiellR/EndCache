using Microsoft.EntityFrameworkCore;

namespace EndCache.Service
{
    public class Context : DbContext
    {
        public Context() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseMySql();
        }

    }
}
