using WebshopApi.Models;
using WebshopApi.Repositories;

namespace WebshopApi.Services;

public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _customerRepository;

    public CustomerService(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public Task<IEnumerable<Customer>> GetAllCustomersAsync()
    {
        return _customerRepository.GetAllCustomersAsync();
    }
}
