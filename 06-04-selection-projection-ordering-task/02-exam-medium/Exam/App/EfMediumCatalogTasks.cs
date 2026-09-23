using Microsoft.EntityFrameworkCore;

namespace App;

public class EfMediumCatalogTasks
{
    private readonly AppDbContext _dbContext;

    public EfMediumCatalogTasks(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    /// <summary>
    /// Keresd meg az első aktív terméket név szerinti sorrendben.
    /// Ha nincs aktív termék, térj vissza null értékkel.
    /// Használj OrderBy-t és FirstOrDefaultAsync-et.
    /// </summary>
    public Task<Product?> FindFirstActiveProductByNameAsync()
    {
        return Task.FromResult<Product?>(null);
    }

    /// <summary>
    /// Keresd meg a terméket pontos SKU alapján.
    /// Az SKU üzletileg egyedi, ezért SingleOrDefaultAsync használata indokolt.
    /// </summary>
    public Task<Product?> FindProductBySkuAsync(string sku)
    {
        return Task.FromResult<Product?>(null);
    }

    /// <summary>
    /// Add vissza az aktív termékeket ProductListItemDto-ként, név szerint rendezve.
    /// A lekérdezésben Select-et használj, hogy csak a szükséges mezők kerüljenek a DTO-ba.
    /// </summary>
    public Task<List<ProductListItemDto>> GetActiveProductListItemsAsync()
    {
        return Task.FromResult(new List<ProductListItemDto>());
    }
}