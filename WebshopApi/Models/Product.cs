namespace WebshopApi.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Description { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public List<CartItem> CartItems { get; set; } = new();
    public List<OrderItem> OrderItems { get; set; } = new();
    public List<ProductCategory> ProductCategories { get; set; } = new();
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
