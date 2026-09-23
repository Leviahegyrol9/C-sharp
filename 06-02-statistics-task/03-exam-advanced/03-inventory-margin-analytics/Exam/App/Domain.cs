public class InventorySnapshot
{
    public int Id { get; set; }
    public string Category { get; set; } = string.Empty;
    public string ProductName { get; set; } = string.Empty;
    public int StockQuantity { get; set; }
    public int ReservedQuantity { get; set; }
    public decimal UnitCost { get; set; }
    public decimal UnitPrice { get; set; }
    public int ReorderLevel { get; set; }
}
