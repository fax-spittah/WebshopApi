using WebshopApi.Models;

namespace WebshopApi.Services;

public interface IUserService
{
    Task<List<User>> GetAllUsersAsync();
    Task<User?> GetUserByIdAsync(int id);
    Task AddUserAsync(User user);
    Task UpdateUserAsync(User existingUser, User updatedUser);
    Task DeleteUserAsync(int id);
}
