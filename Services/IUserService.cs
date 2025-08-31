using WebshopApi.Models;

namespace WebshopApi.Services;
public interface IUserService
{
    Task<IEnumerable<User>> GetAllUsersAsync();
}
