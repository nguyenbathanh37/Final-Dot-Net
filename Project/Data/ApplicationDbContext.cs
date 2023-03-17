using Microsoft.EntityFrameworkCore;

namespace Project.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Models.Menu> Menu { get; set; }
    }
}
