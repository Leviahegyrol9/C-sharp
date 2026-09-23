public static class TestData
{
    public static void Seed(AppDbContext dbContext)
    {
        dbContext.SubscriptionAccounts.AddRange(
            new SubscriptionAccount { Id = 1, CustomerName = "Atlas Kft", Status = "Active", MonthlyFee = 1000m, StartedAsTrial = true, ConvertedFromTrial = true },
            new SubscriptionAccount { Id = 2, CustomerName = "Beta Bt", Status = "Active", MonthlyFee = 1500m, StartedAsTrial = false, ConvertedFromTrial = false },
            new SubscriptionAccount { Id = 3, CustomerName = "Corvus Zrt", Status = "Cancelled", MonthlyFee = 900m, StartedAsTrial = true, ConvertedFromTrial = false },
            new SubscriptionAccount { Id = 4, CustomerName = "Delta Kft", Status = "Active", MonthlyFee = 500m, StartedAsTrial = true, ConvertedFromTrial = true },
            new SubscriptionAccount { Id = 5, CustomerName = "Epsilon Bt", Status = "Cancelled", MonthlyFee = 600m, StartedAsTrial = false, ConvertedFromTrial = false });
        dbContext.SaveChanges();
    }
}
