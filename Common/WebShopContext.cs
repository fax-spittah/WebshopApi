using System.Data.Entity;
using WebshopApi.Models;

namespace WebshopApi.Common;

public class WebShopContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Product> Products { get; set; }
}
