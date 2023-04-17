global using Microsoft.EntityFrameworkCore;

namespace StatusChecker.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base (options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=172.30.100.119;database=INT_FE;trusted_connection=true;");
        }
        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
