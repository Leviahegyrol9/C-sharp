using Microsoft.EntityFrameworkCore;

namespace LinqWhereCountEfBeginner;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Grade { get; set; }
    public bool IsActive { get; set; }
    public string City { get; set; } = string.Empty;
}

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Student> Students => Set<Student>();
}

public static class TestData
{
    public static void Seed(AppDbContext db)
    {
        if (db.Students.Any())
        {
            return;
        }

        db.Students.AddRange(
            new Student { Id = 1, Name = "Anna", Grade = 5, IsActive = true, City = "Budapest" },
            new Student { Id = 2, Name = "Bela", Grade = 1, IsActive = true, City = "Szeged" },
            new Student { Id = 3, Name = "Csaba", Grade = 3, IsActive = false, City = "Budapest" },
            new Student { Id = 4, Name = "Dora", Grade = 2, IsActive = true, City = "Pecs" });
        db.SaveChanges();
    }
}
