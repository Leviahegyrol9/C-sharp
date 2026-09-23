public static class TestData
{
    public static void Seed(AppDbContext dbContext)
    {
        dbContext.Orders.AddRange(
            new Order { Id = 1, CustomerRegion = "EU", DiscountAmount = 10m, IsReturned = false },
            new Order { Id = 2, CustomerRegion = "EU", DiscountAmount = 0m, IsReturned = true },
            new Order { Id = 3, CustomerRegion = "US", DiscountAmount = 20m, IsReturned = false });
        dbContext.OrderItems.AddRange(
            new OrderItem { Id = 1, OrderId = 1, Category = "Book", UnitPrice = 30m, Quantity = 2 },
            new OrderItem { Id = 2, OrderId = 1, Category = "Video", UnitPrice = 50m, Quantity = 1 },
            new OrderItem { Id = 3, OrderId = 2, Category = "Book", UnitPrice = 25m, Quantity = 1 },
            new OrderItem { Id = 4, OrderId = 3, Category = "Hardware", UnitPrice = 100m, Quantity = 2 });
        dbContext.SaveChanges();
    }
}
