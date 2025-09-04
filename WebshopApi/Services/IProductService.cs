using WebshopApi.Models;

namespace WebshopApi.Services;

public interface IProductService
{
    Task<IEnumerable<Product>> GetAllProductsAsync();
}
