using WebshopApi.Models;

namespace WebshopApi.Repositories;

public class UserRepository : IUserRepository
{
    public Task<IEnumerable<User>> GetAllUsersAsync()
    {
        var users = new List<User>
        {
            new User
            {
                Id = 1,
                Name = "John Doe",
                Email = "john@example.com",
                Address = "123 Main St",
            },
            new User
            {
                Id = 2,
                Name = "Jane Smith",
                Email = "jane@example.com",
                Address = "456 Oak Ave",
            },
        };

        return Task.FromResult(users.AsEnumerable());
    }
}
