using Microsoft.EntityFrameworkCore;

namespace App;

public class EfExpertCustomerTasks
{
    private readonly AppDbContext _dbContext;

    public EfExpertCustomerTasks(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    /// <summary>
    /// Keresd meg az első aktív ügyfélkapcsolati bejegyzést név szerinti sorrendben.
    /// Ha nincs aktív rekord, térj vissza null értékkel.
    /// Használj OrderBy-t és FirstOrDefaultAsync-et.
    /// </summary>
    public Task<CustomerContact?> FindFirstActiveByNameAsync()
    {
        return Task.FromResult<CustomerContact?>(null);
    }

    /// <summary>
    /// Keresd meg az ügyfélkapcsolati bejegyzést pontos Code alapján.
    /// A Code üzletileg egyedi, ezért SingleOrDefaultAsync használata indokolt.
    /// </summary>
    public Task<CustomerContact?> FindByCodeAsync(string code)
    {
        return Task.FromResult<CustomerContact?>(null);
    }

    /// <summary>
    /// Add vissza az aktív ügyfélkapcsolati bejegyzéseket CustomerContactResultDto listaként, név szerint rendezve.
    /// A lekérdezésben Select-et használj, hogy csak a DTO-hoz szükséges mezők kerüljenek ki.
    /// </summary>
    public Task<List<CustomerContactResultDto>> GetActiveListItemsAsync()
    {
        return Task.FromResult(new List<CustomerContactResultDto>());
    }
}