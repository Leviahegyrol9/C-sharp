using Microsoft.EntityFrameworkCore;

DbContextOptions<AppDbContext> options = new DbContextOptionsBuilder<AppDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
await using AppDbContext dbContext = new(options);
        var financialMonthlySummaryQuery = new FinancialMonthlySummaryQuery(dbContext);
TestData.Seed(dbContext);

FinancialMonthlySummaryDto summary = await financialMonthlySummaryQuery.CreateSummaryAsync(2026, 9);

AssertDecimal(200_000m, summary.RevenueTotal, "havi bevetel");
AssertDecimal(75_000m, summary.ExpenseTotal, "havi koltseg");
AssertDecimal(125_000m, summary.Profit, "profit");
AssertDouble(62.5, summary.ProfitMarginPercentage, "profit margin");
AssertDouble(80.0, summary.PlanCompletionPercentage, "tervteljesules");

Console.WriteLine("Minden Financial Monthly Summary teszt sikeres.");

static void AssertDecimal(decimal expected, decimal actual, string message)
{
    if (Math.Abs(expected - actual) > 0.000001m) throw new Exception($"{message}: elvart={expected}, aktualis={actual}");
}

static void AssertDouble(double expected, double actual, string message)
{
    if (Math.Abs(expected - actual) > 0.000001) throw new Exception($"{message}: elvart={expected}, aktualis={actual}");
}
