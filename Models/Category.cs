namespace WebshopApi.Models;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<ProductCategory> ProductCategories { get; set; } = new();
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
