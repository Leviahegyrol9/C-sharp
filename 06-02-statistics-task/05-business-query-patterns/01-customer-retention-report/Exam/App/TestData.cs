public static class TestData
{
    public static void Seed(AppDbContext dbContext)
    {
        dbContext.CustomerSubscriptions.AddRange(
            new CustomerSubscription { Id = 1, CustomerName = "Contoso", IsActive = true, MonthlyRecurringRevenue = 1200m, ActiveMonthCount = 14 },
            new CustomerSubscription { Id = 2, CustomerName = "Northwind", IsActive = true, MonthlyRecurringRevenue = 800m, ActiveMonthCount = 9 },
            new CustomerSubscription { Id = 3, CustomerName = "Adventure", IsActive = false, MonthlyRecurringRevenue = 0m, ActiveMonthCount = 4 },
            new CustomerSubscription { Id = 4, CustomerName = "Fabrikam", IsActive = false, MonthlyRecurringRevenue = 0m, ActiveMonthCount = 2 });
        dbContext.SaveChanges();
    }
}
