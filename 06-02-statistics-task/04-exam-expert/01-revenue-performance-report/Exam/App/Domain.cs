public class SalesOrder
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public bool IsClosed { get; set; }
    public bool IsRefunded { get; set; }
    public decimal NetAmount { get; set; }
    public decimal RefundAmount { get; set; }
}

public class MonthlyRevenueTarget
{
    public int Id { get; set; }
    public int Year { get; set; }
    public int Month { get; set; }
    public decimal TargetAmount { get; set; }
}

public class RevenuePerformanceReportDto
{
    public int ClosedOrderCount { get; set; }
    public decimal NetRevenue { get; set; }
    public decimal AverageClosedOrderValue { get; set; }
    public decimal LargestClosedOrderValue { get; set; }
    public double RefundedOrderPercentage { get; set; }
    public double RevenueTargetCompletionPercentage { get; set; }
}
