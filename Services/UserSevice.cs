using WebshopApi.Models;

namespace WebshopApi.Services;
public class UserSevice : IUserService
{
    public Task<IEnumerable<User>> GetAllUsersAsync()
    {
        var users = new List<User>
        {
            new User { Id = 1, Name = "John Doe", Email = "jd@gmail.com" },
            new User { Id = 2, Name = "Jane Smith", Email = "js@gmail.com" }
        };

        return Task.FromResult(users.AsEnumerable());
    }
}
