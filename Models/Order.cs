namespace WebshopApi.Models;

public class Order
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public required User User { get; set; } = null!;
    public DateTime OrderDate { get; set; } = DateTime.UtcNow;
    public decimal TotalAmount { get; set; }
    public List<OrderItem> OrderItems { get; set; } = new();
}
