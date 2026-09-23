using Microsoft.EntityFrameworkCore;

namespace App;

public class EfExpertTrainingTasks
{
    private readonly AppDbContext _dbContext;

    public EfExpertTrainingTasks(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    /// <summary>
    /// Keresd meg az első aktív képzési programot név szerinti sorrendben.
    /// Ha nincs aktív rekord, térj vissza null értékkel.
    /// Használj OrderBy-t és FirstOrDefaultAsync-et.
    /// </summary>
    public Task<TrainingProgram?> FindFirstActiveByNameAsync()
    {
        return Task.FromResult<TrainingProgram?>(null);
    }

    /// <summary>
    /// Keresd meg a képzési programot pontos Code alapján.
    /// A Code üzletileg egyedi, ezért SingleOrDefaultAsync használata indokolt.
    /// </summary>
    public Task<TrainingProgram?> FindByCodeAsync(string code)
    {
        return Task.FromResult<TrainingProgram?>(null);
    }

    /// <summary>
    /// Add vissza az aktív képzési programokat TrainingBrowserResultDto listaként, név szerint rendezve.
    /// A lekérdezésben Select-et használj, hogy csak a DTO-hoz szükséges mezők kerüljenek ki.
    /// </summary>
    public Task<List<TrainingBrowserResultDto>> GetActiveListItemsAsync()
    {
        return Task.FromResult(new List<TrainingBrowserResultDto>());
    }
}