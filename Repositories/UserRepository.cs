using Microsoft.EntityFrameworkCore;
using WebshopApi.Common;
using WebshopApi.Models;

namespace WebshopApi.Repositories;

public class UserRepository : IUserRepository
{
    private readonly WebShopContext _context;

    public UserRepository(WebShopContext context)
    {
        _context = context;
    }

    public async Task<List<User>> GetAllUsersAsync()
    {
        return await _context.Users.ToListAsync();
    }
}
