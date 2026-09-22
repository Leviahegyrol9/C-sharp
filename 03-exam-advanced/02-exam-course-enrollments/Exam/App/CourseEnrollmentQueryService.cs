using Microsoft.EntityFrameworkCore;

namespace LinqWhereCountEfAdvancedCourses;

public class CourseEnrollmentQueryService
{
    private readonly AppDbContext _dbContext;

    public CourseEnrollmentQueryService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    /// <summary>
    /// Számold meg az aktív jelentkezéseket.
    /// Egy jelentkezés akkor aktív, ha a Status mező értéke "Active".
    /// Használj CountAsync hívást kézi számláló változó nélkül.
    /// </summary>
    public async Task<int> CountActiveEnrollmentsAsync()
    {
        await Task.CompletedTask;
        return 0;
    }

    /// <summary>
    /// Add vissza azokat a kurzusokat, amelyekhez legalább minEnrollmentCount jelentkezés tartozik.
    /// A kapcsolt Enrollments gyűjtemény darabszámát Count művelettel vizsgáld.
    /// Használj Where szűrést és ToListAsync materializálást.
    /// </summary>
    public async Task<List<Course>> GetCoursesWithAtLeastEnrollmentsAsync(int minEnrollmentCount)
    {
        await Task.CompletedTask;
        return [];
    }

    /// <summary>
    /// Add vissza azokat a hallgatókat, akik legalább minEnrollmentCount kurzusra jelentkeztek.
    /// A kapcsolt Enrollments gyűjtemény darabszámát Count művelettel vizsgáld.
    /// Használj Where szűrést és ToListAsync materializálást.
    /// </summary>
    public async Task<List<Student>> GetStudentsWithAtLeastEnrollmentsAsync(int minEnrollmentCount)
    {
        await Task.CompletedTask;
        return [];
    }

    /// <summary>
    /// Add vissza a megadott státuszú jelentkezéseket.
    /// A status paramétert az Enrollment.Status mezővel hasonlítsd össze.
    /// Használj Where szűrést és ToListAsync materializálást.
    /// </summary>
    public async Task<List<Enrollment>> GetEnrollmentsByStatusAsync(string status)
    {
        await Task.CompletedTask;
        return [];
    }

    /// <summary>
    /// Számold meg, hány jelentkezés tartozik a megadott kurzuscímhez.
    /// A kapcsolt Course.Title mezőt hasonlítsd össze a courseTitle paraméterrel.
    /// Használj CountAsync hívást kézi számláló változó nélkül.
    /// </summary>
    public async Task<int> CountEnrollmentsForCourseTitleAsync(string courseTitle)
    {
        await Task.CompletedTask;
        return 0;
    }
}