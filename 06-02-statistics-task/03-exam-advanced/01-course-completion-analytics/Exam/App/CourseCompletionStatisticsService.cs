using Microsoft.EntityFrameworkCore;

public class CourseCompletionStatisticsService
{
    private readonly AppDbContext _dbContext;

    public CourseCompletionStatisticsService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    /// <summary>
    /// Szamitsd ki egy tanszek kurzusainak teljesitesi aranyat szazalekban.
    /// Csak a `department` parameterrel megegyezo sorokat hasznald.
    /// Keplet: osszes `CompletedStudentCount` / osszes `EnrolledStudentCount` * 100.
    /// </summary>
    public async Task<double> CalculateCompletionPercentageForDepartmentAsync(string department)
    {
        await Task.CompletedTask;
        return 0;
    }

    /// <summary>
    /// Szamitsd ki, hogy a kotelezo kurzusokon atlagosan hany perc tanulasi ido jut egy beiratkozott hallgatora.
    /// Csak az `IsRequired == true` sorokat hasznald.
    /// Keplet: osszes `TotalWatchMinutes` / osszes `EnrolledStudentCount`.
    /// </summary>
    public async Task<double> CalculateAverageWatchMinutesPerStudentForRequiredCoursesAsync()
    {
        await Task.CompletedTask;
        return 0;
    }

    /// <summary>
    /// Szamold meg, hany kotelezo kurzus teljesitesi aranya van a `minimumCompletionPercentage` kuszob alatt.
    /// Kurzusonkent a teljesitesi arany: `CompletedStudentCount` / `EnrolledStudentCount` * 100.
    /// </summary>
    public async Task<int> CountRequiredCoursesBelowCompletionAsync(double minimumCompletionPercentage)
    {
        await Task.CompletedTask;
        return 0;
    }
}
