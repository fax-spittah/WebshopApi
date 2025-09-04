using WebshopApi.Models;
using WebshopApi.Repositories;

namespace WebshopApi.Services;

public class ProductSevice : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductSevice(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public Task<IEnumerable<Product>> GetAllProductsAsync()
    {
        return _productRepository.GetAllProductsAsync();
    }
}
