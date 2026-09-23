public static class TestData
{
    public static void Seed(AppDbContext dbContext)
    {
        dbContext.CourseCompletions.AddRange(
            new CourseCompletionMetric { Id = 1, Department = "Backend", CourseCode = "BE-101", EnrolledStudentCount = 40, CompletedStudentCount = 32, TotalWatchMinutes = 4800, IsRequired = true },
            new CourseCompletionMetric { Id = 2, Department = "Backend", CourseCode = "BE-201", EnrolledStudentCount = 30, CompletedStudentCount = 18, TotalWatchMinutes = 3900, IsRequired = true },
            new CourseCompletionMetric { Id = 3, Department = "Frontend", CourseCode = "FE-101", EnrolledStudentCount = 50, CompletedStudentCount = 45, TotalWatchMinutes = 5500, IsRequired = true },
            new CourseCompletionMetric { Id = 4, Department = "Frontend", CourseCode = "FE-UX", EnrolledStudentCount = 20, CompletedStudentCount = 10, TotalWatchMinutes = 1200, IsRequired = false });
        dbContext.SaveChanges();
    }
}
