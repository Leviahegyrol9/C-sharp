public class Order
{
    public int Id { get; set; }
    public string CustomerRegion { get; set; } = string.Empty;
    public decimal DiscountAmount { get; set; }
    public bool IsReturned { get; set; }
    public List<OrderItem> Items { get; set; } = [];
}

public class OrderItem
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public string Category { get; set; } = string.Empty;
    public decimal UnitPrice { get; set; }
    public int Quantity { get; set; }
    public Order? Order { get; set; }
}
