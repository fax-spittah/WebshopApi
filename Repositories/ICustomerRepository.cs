using WebshopApi.Models;

namespace WebshopApi.Repositories;

public interface ICustomerRepository
{
    Task<IEnumerable<Customer>> GetAllCustomersAsync();
}
