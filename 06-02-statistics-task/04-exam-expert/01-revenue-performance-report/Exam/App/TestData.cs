public static class TestData
{
    public static void Seed(AppDbContext dbContext)
    {
        dbContext.SalesOrders.AddRange(
            new SalesOrder { Id = 1, OrderDate = new DateTime(2026, 9, 2), IsClosed = true, IsRefunded = false, NetAmount = 1000m, RefundAmount = 0m },
            new SalesOrder { Id = 2, OrderDate = new DateTime(2026, 9, 5), IsClosed = true, IsRefunded = false, NetAmount = 1500m, RefundAmount = 0m },
            new SalesOrder { Id = 3, OrderDate = new DateTime(2026, 9, 7), IsClosed = true, IsRefunded = true, NetAmount = 700m, RefundAmount = 700m },
            new SalesOrder { Id = 4, OrderDate = new DateTime(2026, 9, 9), IsClosed = false, IsRefunded = false, NetAmount = 900m, RefundAmount = 0m },
            new SalesOrder { Id = 5, OrderDate = new DateTime(2026, 9, 11), IsClosed = true, IsRefunded = false, NetAmount = 500m, RefundAmount = 0m },
            new SalesOrder { Id = 6, OrderDate = new DateTime(2026, 8, 20), IsClosed = true, IsRefunded = false, NetAmount = 2000m, RefundAmount = 0m });

        dbContext.MonthlyRevenueTargets.Add(new MonthlyRevenueTarget { Id = 1, Year = 2026, Month = 9, TargetAmount = 4000m });
        dbContext.SaveChanges();
    }
}
