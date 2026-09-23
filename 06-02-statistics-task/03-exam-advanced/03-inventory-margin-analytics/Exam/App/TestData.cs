public static class TestData
{
    public static void Seed(AppDbContext dbContext)
    {
        dbContext.InventorySnapshots.AddRange(
            new InventorySnapshot { Id = 1, Category = "Hardware", ProductName = "Keyboard", StockQuantity = 120, ReservedQuantity = 20, UnitCost = 8m, UnitPrice = 20m, ReorderLevel = 30 },
            new InventorySnapshot { Id = 2, Category = "Hardware", ProductName = "Mouse", StockQuantity = 25, ReservedQuantity = 5, UnitCost = 5m, UnitPrice = 15m, ReorderLevel = 40 },
            new InventorySnapshot { Id = 3, Category = "Software", ProductName = "IDE License", StockQuantity = 80, ReservedQuantity = 10, UnitCost = 30m, UnitPrice = 99m, ReorderLevel = 20 },
            new InventorySnapshot { Id = 4, Category = "Software", ProductName = "Monitoring Seat", StockQuantity = 10, ReservedQuantity = 2, UnitCost = 15m, UnitPrice = 49m, ReorderLevel = 15 });
        dbContext.SaveChanges();
    }
}
