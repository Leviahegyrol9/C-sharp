using Microsoft.EntityFrameworkCore;

namespace App;

public class EfAdvancedCourseTasks
{
    private readonly AppDbContext _dbContext;

    public EfAdvancedCourseTasks(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    /// <summary>
    /// Keresd meg az első aktív kurzust név szerinti sorrendben.
    /// Ha nincs aktív rekord, térj vissza null értékkel.
    /// Használj OrderBy-t és FirstOrDefaultAsync-et.
    /// </summary>
    public Task<Course?> FindFirstActiveByNameAsync()
    {
        return Task.FromResult<Course?>(null);
    }

    /// <summary>
    /// Keresd meg a kurzust pontos Code alapján.
    /// A Code üzletileg egyedi, ezért SingleOrDefaultAsync használata indokolt.
    /// </summary>
    public Task<Course?> FindByCodeAsync(string code)
    {
        return Task.FromResult<Course?>(null);
    }

    /// <summary>
    /// Add vissza az aktív kurzusokat CourseListItemDto listaként, név szerint rendezve.
    /// A lekérdezésben Select-et használj, hogy csak a DTO-hoz szükséges mezők kerüljenek ki.
    /// </summary>
    public Task<List<CourseListItemDto>> GetActiveListItemsAsync()
    {
        return Task.FromResult(new List<CourseListItemDto>());
    }
}