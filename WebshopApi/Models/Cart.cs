namespace WebshopApi.Models;

public class Cart
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public required User User { get; set; }
    public List<CartItem> CartItems { get; set; } = new();
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
