public class CourseBusinessMetric
{
    public int Id { get; set; }
    public string Category { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public bool IsPublished { get; set; }
    public int EnrollmentCount { get; set; }
    public int SuccessfulCompletionCount { get; set; }
    public double CompletionPercentage { get; set; }
    public decimal Price { get; set; }
}

public class CourseBusinessAnalyticsDto
{
    public int PublishedCourseCount { get; set; }
    public int TotalEnrollmentCount { get; set; }
    public double AverageCompletionPercentage { get; set; }
    public double LowestCompletionPercentage { get; set; }
    public decimal TotalRevenue { get; set; }
    public double SuccessfulCompletionPercentage { get; set; }
}
