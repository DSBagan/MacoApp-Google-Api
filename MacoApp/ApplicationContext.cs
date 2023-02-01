using Microsoft.EntityFrameworkCore;

namespace MacoApp
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Element> Elements { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Macoapp.db");
        }
    }
}
