using Microsoft.EntityFrameworkCore;

namespace App;

public class EfExpertCatalogTasks
{
    private readonly AppDbContext _dbContext;

    public EfExpertCatalogTasks(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    /// <summary>
    /// Keresd meg az első aktív katalóguselemet név szerinti sorrendben.
    /// Ha nincs aktív rekord, térj vissza null értékkel.
    /// Használj OrderBy-t és FirstOrDefaultAsync-et.
    /// </summary>
    public Task<CatalogItem?> FindFirstActiveByNameAsync()
    {
        return Task.FromResult<CatalogItem?>(null);
    }

    /// <summary>
    /// Keresd meg a katalóguselemet pontos Code alapján.
    /// A Code üzletileg egyedi, ezért SingleOrDefaultAsync használata indokolt.
    /// </summary>
    public Task<CatalogItem?> FindByCodeAsync(string code)
    {
        return Task.FromResult<CatalogItem?>(null);
    }

    /// <summary>
    /// Add vissza az aktív katalóguselemeket CatalogSearchResultDto listaként, név szerint rendezve.
    /// A lekérdezésben Select-et használj, hogy csak a DTO-hoz szükséges mezők kerüljenek ki.
    /// </summary>
    public Task<List<CatalogSearchResultDto>> GetActiveListItemsAsync()
    {
        return Task.FromResult(new List<CatalogSearchResultDto>());
    }
}