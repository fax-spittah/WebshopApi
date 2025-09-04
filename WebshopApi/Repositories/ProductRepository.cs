using WebshopApi.Models;

namespace WebshopApi.Repositories;

public class ProductRepository : IProductRepository
{
    public Task<IEnumerable<Product>> GetAllProductsAsync()
    {
        var products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Product 1",
                Price = 10.99M,
                Description = "Description for Product 1",
            },
            new Product
            {
                Id = 2,
                Name = "Product 2",
                Price = 20.99M,
                Description = "Description for Product 2",
            },
            new Product
            {
                Id = 3,
                Name = "Product 3",
                Price = 30.99M,
                Description = "Description for Product 3",
            },
        };

        return Task.FromResult(products.AsEnumerable());
    }
}
