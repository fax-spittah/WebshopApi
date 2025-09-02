using WebshopApi.Models;

namespace WebshopApi.Services;

public interface IUserService
{
    Task<List<User>> GetAllUsersAsync();
}
