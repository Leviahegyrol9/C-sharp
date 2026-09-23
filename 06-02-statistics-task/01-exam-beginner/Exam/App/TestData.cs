public static class TestData
{
    public static void Seed(AppDbContext dbContext)
    {
        dbContext.StudentScores.AddRange(
            new StudentScore { Id = 1, StudentName = "Anna", Points = 82, StudyMinutes = 240, IsPassed = true },
            new StudentScore { Id = 2, StudentName = "Bela", Points = 64, StudyMinutes = 180, IsPassed = true },
            new StudentScore { Id = 3, StudentName = "Csilla", Points = 45, StudyMinutes = 90, IsPassed = false });
        dbContext.SaveChanges();
    }
}
