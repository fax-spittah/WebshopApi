using Microsoft.AspNetCore.Mvc;
using WebshopApi.Models;
using WebshopApi.Services;

namespace WebshopApi.Controllers;

[Route("users")]
public class UserController : Controller
{
    private readonly ILogger<UserController> _logger;
    private readonly IUserService _userService;

    public UserController(ILogger<UserController> logger, IUserService userService)
    {
        _logger = logger;
        _userService = userService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllUsers()
    {
        var users = await _userService.GetAllUsersAsync();
        return Ok(users);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetUserById(int id)
    {
        var user = await _userService.GetUserByIdAsync(id);
        if (user == null)
        {
            return NotFound();
        }
        return Ok(user);
    }

    [HttpPost]
    public async Task<IActionResult> AddUser([FromBody] User user)
    {
        await _userService.AddUserAsync(user);
        return Ok(user);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateUser(int id, [FromBody] User updatedUser)
    {
        if (id != updatedUser.Id)
        {
            return BadRequest("User ID mismatch");
        }

        var existingUser = await _userService.GetUserByIdAsync(id);
        if (existingUser == null)
        {
            return NotFound();
        }

        await _userService.UpdateUserAsync(existingUser, updatedUser);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUser(int id)
    {
        var existingUser = await _userService.GetUserByIdAsync(id);
        if (existingUser == null)
        {
            return NotFound();
        }

        await _userService.DeleteUserAsync(id);
        return NoContent();
    }
}
