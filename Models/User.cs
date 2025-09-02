namespace WebshopApi.Models;

public class User
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    public string Role { get; set; } = Roles.Customer;
    public string Address { get; set; } = string.Empty;
}
