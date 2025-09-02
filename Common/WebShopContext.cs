using Microsoft.EntityFrameworkCore;
using WebshopApi.Models;

namespace WebshopApi.Common;

public class WebShopContext : DbContext
{
    public WebShopContext(DbContextOptions<WebShopContext> options)
        : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
}
