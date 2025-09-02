-- Users
INSERT INTO [Users] ([Name], [Email], [Password], [Role], [Address], [CreatedAt])
VALUES
('Admin User', 'admin@webshop.com', 'admin123', 'Admin', '123 Admin Street', GETUTCDATE()),
('John Doe', 'john@example.com', 'user123', 'Customer', '456 Customer Lane', GETUTCDATE());

-- Categories
INSERT INTO [Categories] ([Name], [Description], [CreatedAt])
VALUES
('Electronics', '', GETUTCDATE()),
('Clothing', '', GETUTCDATE()),
('Books', '', GETUTCDATE());

-- Products
INSERT INTO [Products] ([Name], [Description], [Price], [ImageUrl], [CreatedAt])
VALUES
('Laptop', 'High-performance laptop', 999.99, '', GETUTCDATE()),
('T-Shirt', 'Cotton T-Shirt', 19.99, '', GETUTCDATE()),
('Programming Book', 'Learn coding', 49.99, '', GETUTCDATE());

-- ProductCategories
INSERT INTO [ProductCategories] ([ProductId], [CategoryId])
VALUES
(1, 1), 
(2, 2), 
(3, 3); 
