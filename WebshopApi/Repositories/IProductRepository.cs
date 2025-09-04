using WebshopApi.Models;

namespace WebshopApi.Repositories;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllProductsAsync();
}
