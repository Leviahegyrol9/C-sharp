public class WarehouseStockItem
{
    public int Id { get; set; }
    public string WarehouseCode { get; set; } = string.Empty;
    public string ProductName { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public int ReorderLevel { get; set; }
    public int ReorderQuantity { get; set; }
    public decimal UnitCost { get; set; }
}

public class WarehouseEfficiencyReportDto
{
    public int ProductCount { get; set; }
    public decimal TotalStockValue { get; set; }
    public double AverageStockLevel { get; set; }
    public int LowestStockLevel { get; set; }
    public double LowStockProductPercentage { get; set; }
    public decimal EstimatedReorderCost { get; set; }
}
