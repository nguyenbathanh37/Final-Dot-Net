using Microsoft.EntityFrameworkCore;

namespace Project.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Models.Menu> Menu { get; set; }

        public DbSet<Models.Film> Films { get; set; }
        public DbSet<Models.FilmType> FilmTypes { get; set; }
        public DbSet<Models.User> Users { get; set; }
        public DbSet<Models.Comment> Comments { get; set; }
        public DbSet<Models.Blog> Blogs { get; set; }
    }
}
