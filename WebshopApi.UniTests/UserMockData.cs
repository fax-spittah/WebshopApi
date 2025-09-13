using WebshopApi.Models;

public static class UserMockData
{
    public static List<User> GetUsers()
    {
        var product1 = new Product
        {
            Id = 1,
            Name = "Laptop",
            Price = 999.99m,
            Description = "A powerful laptop.",
        };
        var product2 = new Product
        {
            Id = 2,
            Name = "Phone",
            Price = 499.99m,
            Description = "A smart phone.",
        };
        var product3 = new Product
        {
            Id = 3,
            Name = "Headphones",
            Price = 199.99m,
            Description = "Noise-cancelling headphones.",
        };

        var user1 = new User
        {
            Id = 1,
            Name = "Alice Johnson",
            Email = "alice@example.com",
            Password = "Password123!",
            Role = Roles.Customer,
            Address = "123 Main St, Springfield",
            CreatedAt = DateTime.UtcNow.AddDays(-30),
        };
        var user2 = new User
        {
            Id = 2,
            Name = "Bob Smith",
            Email = "bob@example.com",
            Password = "SecurePass456!",
            Role = Roles.Admin,
            Address = "456 Market Ave, Capital City",
            CreatedAt = DateTime.UtcNow.AddDays(-60),
        };
        var user3 = new User
        {
            Id = 3,
            Name = "Charlie Brown",
            Email = "charlie@example.com",
            Password = "TestPass789!",
            Role = Roles.Customer,
            Address = "789 Broadway Blvd, Metropolis",
            CreatedAt = DateTime.UtcNow.AddDays(-7),
        };
        var user4 = new User
        {
            Id = 4,
            Name = "Diana Prince",
            Email = "diana@example.com",
            Password = "WonderWoman!",
            Role = Roles.Customer,
            Address = "Themyscira Island",
            CreatedAt = DateTime.UtcNow.AddDays(-90),
        };

        var cart1 = new Cart
        {
            Id = 1,
            UserId = 1,
            User = user1,
            CreatedAt = DateTime.UtcNow.AddDays(-29),
            CartItems = new List<CartItem>(),
        };
        var cart2 = new Cart
        {
            Id = 2,
            UserId = 3,
            User = user3,
            CreatedAt = DateTime.UtcNow.AddDays(-6),
            CartItems = new List<CartItem>(),
        };
        var cart3 = new Cart
        {
            Id = 3,
            UserId = 2,
            User = user2,
            CreatedAt = DateTime.UtcNow.AddDays(-59),
            CartItems = new List<CartItem>(),
        };
        var cart4 = new Cart
        {
            Id = 4,
            UserId = 4,
            User = user4,
            CreatedAt = DateTime.UtcNow.AddDays(-89),
            CartItems = new List<CartItem>(),
        };

        var cartItem1 = new CartItem
        {
            Id = 1,
            ProductId = 1,
            CartId = 1,
            Quantity = 1,
            Price = 999.99m,
            Cart = cart1,
            Product = product1,
        };
        var cartItem2 = new CartItem
        {
            Id = 2,
            ProductId = 2,
            CartId = 2,
            Quantity = 2,
            Price = 499.99m,
            Cart = cart2,
            Product = product2,
        };
        var cartItem3 = new CartItem
        {
            Id = 3,
            ProductId = 3,
            CartId = 3,
            Quantity = 1,
            Price = 199.99m,
            Cart = cart3,
            Product = product3,
        };
        var cartItem4 = new CartItem
        {
            Id = 4,
            ProductId = 1,
            CartId = 4,
            Quantity = 3,
            Price = 999.99m,
            Cart = cart4,
            Product = product1,
        };

        cart1.CartItems.Add(cartItem1);
        cart2.CartItems.Add(cartItem2);
        cart3.CartItems.Add(cartItem3);
        cart4.CartItems.Add(cartItem4);

        user1.Cart = cart1;
        user2.Cart = cart3;
        user3.Cart = cart2;
        user4.Cart = cart4;

        return new List<User> { user1, user2, user3, user4 };
    }
}
