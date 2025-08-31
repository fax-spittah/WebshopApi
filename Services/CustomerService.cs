using WebshopApi.Models;

namespace WebshopApi.Services;
public class CustomerService : ICustomerService
{
    public Task<IEnumerable<Customer>> GetAllCustomersAsync()
    {
        var customers = new List<Customer>
        {
            new Customer { Id = 1, Name = "John Doe", Email = "jd@gmail.com" },
            new Customer { Id = 2, Name = "Jane Smith", Email = "js@gmail.com" }
        };

        return Task.FromResult(customers.AsEnumerable());
    }
}
