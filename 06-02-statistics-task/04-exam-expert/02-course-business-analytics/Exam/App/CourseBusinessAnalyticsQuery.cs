using Microsoft.EntityFrameworkCore;

public class CourseBusinessAnalyticsQuery
{
    private readonly AppDbContext _dbContext;

    public CourseBusinessAnalyticsQuery(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    /// <summary>
    /// Keszits uzleti statisztikat a megadott kategoria publikus kurzusairol.
    /// Szamold ki a kurzusok es beiratkozasok szamat, az atlagos es legalacsonyabb teljesitesi aranyt,
    /// a becsult bevetelt, valamint a sikeres teljesitesek aranyat az osszes beiratkozashoz kepest.
    /// A szazalekszamitasnal nulla beiratkozas eseten 0 legyen az eredmeny.
    /// </summary>
    public async Task<CourseBusinessAnalyticsDto> CreateReportAsync(string category)
    {
        await Task.CompletedTask;
        return new CourseBusinessAnalyticsDto();
    }
}
