using WebshopApi.Models;

namespace WebshopApi.Repositories;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetAllUsersAsync();
}
