public static class TestData
{
    public static void Seed(AppDbContext dbContext)
    {
        dbContext.CourseBusinessMetrics.AddRange(
            new CourseBusinessMetric { Id = 1, Category = "Backend", Title = "REST API alapok", IsPublished = true, EnrollmentCount = 40, SuccessfulCompletionCount = 30, CompletionPercentage = 75, Price = 120m },
            new CourseBusinessMetric { Id = 2, Category = "Backend", Title = "EF Core gyakorlat", IsPublished = true, EnrollmentCount = 25, SuccessfulCompletionCount = 15, CompletionPercentage = 60, Price = 100m },
            new CourseBusinessMetric { Id = 3, Category = "Backend", Title = "LINQ riportok", IsPublished = true, EnrollmentCount = 35, SuccessfulCompletionCount = 33, CompletionPercentage = 90, Price = 150m },
            new CourseBusinessMetric { Id = 4, Category = "Backend", Title = "Nem publikus beta", IsPublished = false, EnrollmentCount = 20, SuccessfulCompletionCount = 10, CompletionPercentage = 50, Price = 80m },
            new CourseBusinessMetric { Id = 5, Category = "Frontend", Title = "CSS layout", IsPublished = true, EnrollmentCount = 60, SuccessfulCompletionCount = 42, CompletionPercentage = 70, Price = 90m });
        dbContext.SaveChanges();
    }
}
