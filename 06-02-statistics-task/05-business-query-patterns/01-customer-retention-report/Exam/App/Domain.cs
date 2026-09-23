public class CustomerSubscription
{
    public int Id { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public bool IsActive { get; set; }
    public decimal MonthlyRecurringRevenue { get; set; }
    public int ActiveMonthCount { get; set; }
}

public class CustomerRetentionReportDto
{
    public int TotalCustomerCount { get; set; }
    public int ActiveCustomerCount { get; set; }
    public int ChurnedCustomerCount { get; set; }
    public double ChurnPercentage { get; set; }
    public decimal AverageActiveMonthlyRevenue { get; set; }
}
