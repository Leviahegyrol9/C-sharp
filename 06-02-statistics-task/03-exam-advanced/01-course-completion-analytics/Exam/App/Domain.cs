public class CourseCompletionMetric
{
    public int Id { get; set; }
    public string Department { get; set; } = string.Empty;
    public string CourseCode { get; set; } = string.Empty;
    public int EnrolledStudentCount { get; set; }
    public int CompletedStudentCount { get; set; }
    public int TotalWatchMinutes { get; set; }
    public bool IsRequired { get; set; }
}
