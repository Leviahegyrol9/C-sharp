public class SubscriptionAccount
{
    public int Id { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public decimal MonthlyFee { get; set; }
    public bool StartedAsTrial { get; set; }
    public bool ConvertedFromTrial { get; set; }
}

public class SubscriptionHealthReportDto
{
    public int CustomerCount { get; set; }
    public int ActiveCustomerCount { get; set; }
    public int CancelledCustomerCount { get; set; }
    public decimal MonthlyRecurringRevenue { get; set; }
    public decimal AverageActiveMonthlyFee { get; set; }
    public double ChurnPercentage { get; set; }
    public double TrialConversionPercentage { get; set; }
}
