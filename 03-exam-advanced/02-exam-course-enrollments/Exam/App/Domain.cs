namespace LinqWhereCountEfAdvancedCourses;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<Enrollment> Enrollments { get; set; } = [];
}

public class Course
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public List<Enrollment> Enrollments { get; set; } = [];
}

public class Enrollment
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public string Status { get; set; } = string.Empty;
    public Student? Student { get; set; }
    public Course? Course { get; set; }
}