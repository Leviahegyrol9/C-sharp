namespace LinqWhereCountEfAdvancedCourses;

public static class TestData
{
    public static void Seed(AppDbContext db)
    {
        db.Students.AddRange(new Student { Id = 1, Name = "Anna" }, new Student { Id = 2, Name = "Bela" }, new Student { Id = 3, Name = "Csilla" });
        db.Courses.AddRange(new Course { Id = 10, Title = "Backend" }, new Course { Id = 20, Title = "Frontend" }, new Course { Id = 30, Title = "Database" });
        db.Enrollments.AddRange(
            new Enrollment { Id = 1, StudentId = 1, CourseId = 10, Status = "Active" },
            new Enrollment { Id = 2, StudentId = 1, CourseId = 20, Status = "Active" },
            new Enrollment { Id = 3, StudentId = 2, CourseId = 10, Status = "Cancelled" },
            new Enrollment { Id = 4, StudentId = 3, CourseId = 10, Status = "Active" }
        );
        db.SaveChanges();
    }
}