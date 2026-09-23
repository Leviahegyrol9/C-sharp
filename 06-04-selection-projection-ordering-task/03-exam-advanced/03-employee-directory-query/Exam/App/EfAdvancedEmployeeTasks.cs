using Microsoft.EntityFrameworkCore;

namespace App;

public class EfAdvancedEmployeeTasks
{
    private readonly AppDbContext _dbContext;

    public EfAdvancedEmployeeTasks(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    /// <summary>
    /// Keresd meg az első aktív munkatársat név szerinti sorrendben.
    /// Ha nincs aktív rekord, térj vissza null értékkel.
    /// Használj OrderBy-t és FirstOrDefaultAsync-et.
    /// </summary>
    public Task<EmployeeProfile?> FindFirstActiveByNameAsync()
    {
        return Task.FromResult<EmployeeProfile?>(null);
    }

    /// <summary>
    /// Keresd meg a munkatársat pontos Code alapján.
    /// A Code üzletileg egyedi, ezért SingleOrDefaultAsync használata indokolt.
    /// </summary>
    public Task<EmployeeProfile?> FindByCodeAsync(string code)
    {
        return Task.FromResult<EmployeeProfile?>(null);
    }

    /// <summary>
    /// Add vissza az aktív munkatársakat EmployeeListItemDto listaként, név szerint rendezve.
    /// A lekérdezésben Select-et használj, hogy csak a DTO-hoz szükséges mezők kerüljenek ki.
    /// </summary>
    public Task<List<EmployeeListItemDto>> GetActiveListItemsAsync()
    {
        return Task.FromResult(new List<EmployeeListItemDto>());
    }
}