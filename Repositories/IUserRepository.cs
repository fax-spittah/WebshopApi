using WebshopApi.Models;

namespace WebshopApi.Repositories;

public interface IUserRepository
{
    Task<List<User>> GetAllUsersAsync();
}
