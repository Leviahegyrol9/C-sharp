public static class TestData
{
    public static void Seed(AppDbContext dbContext)
    {
        dbContext.ProductInventories.AddRange(
            new ProductInventory { Id = 1, ProductName = "Keyboard", Category = "Hardware", StockQuantity = 120, UnitCost = 8m, UnitPrice = 20m, ReorderLevel = 30 },
            new ProductInventory { Id = 2, ProductName = "Mouse", Category = "Hardware", StockQuantity = 25, UnitCost = 5m, UnitPrice = 15m, ReorderLevel = 40 },
            new ProductInventory { Id = 3, ProductName = "IDE License", Category = "Software", StockQuantity = 80, UnitCost = 30m, UnitPrice = 99m, ReorderLevel = 20 });
        dbContext.SaveChanges();
    }
}
