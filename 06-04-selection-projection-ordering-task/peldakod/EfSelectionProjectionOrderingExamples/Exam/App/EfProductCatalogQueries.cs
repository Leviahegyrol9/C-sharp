using Microsoft.EntityFrameworkCore;

namespace App;

public class EfProductCatalogQueries
{
    private readonly AppDbContext _dbContext;

    public EfProductCatalogQueries(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// Keresd meg az első aktív terméket név szerinti sorrendben.
    /// Ha nincs aktív termék, térj vissza null értékkel.
    /// </summary>
    public async Task<Product?> FindFirstActiveProductByNameAsync()
    {
        return await _dbContext.Products
            .Where(product => product.IsActive)
            .OrderBy(product => product.Name)
            .FirstOrDefaultAsync();
    }

    /// <summary>
    /// Keresd meg a terméket pontos SKU alapján.
    /// Az SKU üzletileg egyedi, ezért SingleOrDefaultAsync használata indokolt.
    /// </summary>
    public async Task<Product?> FindProductBySkuAsync(string sku)
    {
        return await _dbContext.Products
            .SingleOrDefaultAsync(product => product.Sku == sku);
    }

    /// <summary>
    /// Add vissza az aktív termékeket ProductListItemDto-ként, név szerint rendezve.
    /// A Select csak a DTO-hoz szükséges mezőket vetítse ki.
    /// </summary>
    public async Task<List<ProductListItemDto>> GetActiveProductListItemsAsync()
    {
        return await _dbContext.Products
            .Where(product => product.IsActive)
            .OrderBy(product => product.Name)
            .Select(product => new ProductListItemDto(product.Id, product.Name, product.Category, product.Price))
            .ToListAsync();
    }
}
