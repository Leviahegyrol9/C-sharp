public class Invoice
{
    public int Id { get; set; }
    public int Year { get; set; }
    public int Month { get; set; }
    public decimal Amount { get; set; }
}

public class Expense
{
    public int Id { get; set; }
    public int Year { get; set; }
    public int Month { get; set; }
    public decimal Amount { get; set; }
}

public class MonthlyPlan
{
    public int Id { get; set; }
    public int Year { get; set; }
    public int Month { get; set; }
    public decimal PlannedRevenue { get; set; }
}

public class FinancialMonthlySummaryDto
{
    public decimal RevenueTotal { get; set; }
    public decimal ExpenseTotal { get; set; }
    public decimal Profit { get; set; }
    public double ProfitMarginPercentage { get; set; }
    public double PlanCompletionPercentage { get; set; }
}
