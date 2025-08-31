using WebshopApi.Models;

namespace WebshopApi.Services;
public interface ICustomerService
{
    Task<IEnumerable<Customer>> GetAllCustomersAsync();
}
