public static class TestData
{
    public static void Seed(AppDbContext dbContext)
    {
        dbContext.Invoices.AddRange(
            new Invoice { Id = 1, Year = 2026, Month = 9, Amount = 120_000m },
            new Invoice { Id = 2, Year = 2026, Month = 9, Amount = 80_000m },
            new Invoice { Id = 3, Year = 2026, Month = 8, Amount = 50_000m });
        dbContext.Expenses.AddRange(
            new Expense { Id = 1, Year = 2026, Month = 9, Amount = 40_000m },
            new Expense { Id = 2, Year = 2026, Month = 9, Amount = 35_000m },
            new Expense { Id = 3, Year = 2026, Month = 8, Amount = 10_000m });
        dbContext.MonthlyPlans.Add(new MonthlyPlan { Id = 1, Year = 2026, Month = 9, PlannedRevenue = 250_000m });
        dbContext.SaveChanges();
    }
}
