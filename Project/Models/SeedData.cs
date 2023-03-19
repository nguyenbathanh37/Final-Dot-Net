using Microsoft.EntityFrameworkCore;

namespace Project.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Data.ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Data.ApplicationDbContext>>()))
            {
                // Look for any movies.
                if (context.Menu.Any())
                {
                    return;   // DB has been seeded
                }
                context.Menu.AddRange(
                    new Menu
                    {
                        MenuName = "Home Page",
                        MenuLink = "Index",
                        MenuMeta = "trang-chủ",
                        MenuHide = 1,
                        MenuOrder = 1
                    },
                    new Menu
                    {
                        MenuName = "Categories",
                        MenuLink = "Categories",
                        MenuMeta = "Categories",
                        MenuHide = 1,
                        MenuOrder = 2
                    },
                    new Menu
                    {
                        MenuName = "Our Blog",
                        MenuLink = "BlogDetails",
                        MenuMeta = "chi-tiết-blog",
                        MenuHide = 1,
                        MenuOrder = 3
                    },
                    new Menu
                    {
                        MenuName = "Contacts",
                        MenuLink = "Contacts",
                        MenuMeta = "liên-hệ",
                        MenuHide = 1,
                        MenuOrder = 4
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
