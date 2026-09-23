public static class TestData
{
    public static void Seed(AppDbContext dbContext)
    {
        dbContext.WarehouseStockItems.AddRange(
            new WarehouseStockItem { Id = 1, WarehouseCode = "BUD-1", ProductName = "Monitor", Quantity = 12, ReorderLevel = 5, ReorderQuantity = 10, UnitCost = 50000m },
            new WarehouseStockItem { Id = 2, WarehouseCode = "BUD-1", ProductName = "Keyboard", Quantity = 4, ReorderLevel = 10, ReorderQuantity = 20, UnitCost = 8000m },
            new WarehouseStockItem { Id = 3, WarehouseCode = "BUD-1", ProductName = "Mouse", Quantity = 2, ReorderLevel = 8, ReorderQuantity = 30, UnitCost = 4000m },
            new WarehouseStockItem { Id = 4, WarehouseCode = "BUD-1", ProductName = "Dock", Quantity = 9, ReorderLevel = 6, ReorderQuantity = 8, UnitCost = 30000m },
            new WarehouseStockItem { Id = 5, WarehouseCode = "DEB-1", ProductName = "Monitor", Quantity = 20, ReorderLevel = 5, ReorderQuantity = 10, UnitCost = 50000m });
        dbContext.SaveChanges();
    }
}
