using Microsoft.EntityFrameworkCore;
using WebshopApi.Models;

namespace WebshopApi.Seeds;

public static class ModelBuilderExtensions
{
    private static DateTime SeedTime = new DateTime(2025, 9, 2, 0, 0, 0);

    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<User>()
            .HasData(
                new User
                {
                    Id = 1,
                    Name = "Admin User",
                    Email = "admin@webshop.com",
                    Password = "admin123",
                    Role = Roles.Admin,
                    Address = "123 Admin Street",
                    CreatedAt = SeedTime,
                },
                new User
                {
                    Id = 2,
                    Name = "John Doe",
                    Email = "john@example.com",
                    Password = "user123",
                    Role = Roles.Customer,
                    Address = "456 Customer Lane",
                    CreatedAt = SeedTime,
                }
            );

        modelBuilder
            .Entity<Category>()
            .HasData(
                new Category { Id = 1, Name = "Electronics" },
                new Category { Id = 2, Name = "Clothing" },
                new Category { Id = 3, Name = "Books" }
            );

        modelBuilder
            .Entity<Product>()
            .HasData(
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Description = "High-performance laptop",
                    Price = 999.99m,
                    CreatedAt = SeedTime,
                },
                new Product
                {
                    Id = 2,
                    Name = "T-Shirt",
                    Description = "Cotton T-Shirt",
                    Price = 19.99m,
                    CreatedAt = SeedTime,
                },
                new Product
                {
                    Id = 3,
                    Name = "Programming Book",
                    Description = "Learn coding",
                    Price = 49.99m,
                    CreatedAt = SeedTime,
                }
            );

        modelBuilder
            .Entity<ProductCategory>()
            .HasData(
                new ProductCategory
                {
                    Id = 1,
                    ProductId = 1,
                    CategoryId = 1,
                },
                new ProductCategory
                {
                    Id = 2,
                    ProductId = 2,
                    CategoryId = 2,
                },
                new ProductCategory
                {
                    Id = 3,
                    ProductId = 3,
                    CategoryId = 3,
                }
            );
    }
}
