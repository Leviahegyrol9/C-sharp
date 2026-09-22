namespace LinqWhereCountEfMedium;

public class ProductQueryService
{
    private readonly AppDbContext _dbContext;

    public ProductQueryService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    /// <summary>
    /// Add vissza azokat a termékeket az adatbázisból, amelyek készleten vannak.
    /// Egy termék akkor van készleten, ha az InStock értéke true.
    /// Használj Where szűrést és ToListAsync materializálást.
    /// </summary>
    public async Task<List<Product>> GetProductsInStockAsync()
    {
        await Task.CompletedTask;
        return [];
    }

    /// <summary>
    /// Számold meg azokat a termékeket, amelyek nincsenek készleten.
    /// Egy termék akkor nincs készleten, ha az InStock értéke false.
    /// Használj CountAsync hívást, kézi számláló változó nélkül.
    /// </summary>
    public async Task<int> CountOutOfStockProductsAsync()
    {
        await Task.CompletedTask;
        return 0;
    }

    /// <summary>
    /// Add vissza azokat a termékeket, amelyek ára kisebb, mint a maxPrice paraméter értéke.
    /// A szűrést a Product.Price mező alapján végezd.
    /// Használj Where szűrést és ToListAsync materializálást.
    /// </summary>
    public async Task<List<Product>> GetProductsCheaperThanAsync(decimal maxPrice)
    {
        await Task.CompletedTask;
        return [];
    }

    /// <summary>
    /// Számold meg azokat a termékeket, amelyek ára a megadott intervallumba esik.
    /// A minPrice és maxPrice határok is beleszámítanak az intervallumba.
    /// Használj CountAsync hívást, kézi számláló változó nélkül.
    /// </summary>
    public async Task<int> CountProductsInPriceRangeAsync(decimal minPrice, decimal maxPrice)
    {
        await Task.CompletedTask;
        return 0;
    }

    /// <summary>
    /// Add vissza azokat a termékeket, amelyek akciósak és készleten is vannak.
    /// Az akciós termékeket az IsDiscounted mező true értéke jelöli.
    /// Használj többfeltételes Where szűrést és ToListAsync materializálást.
    /// </summary>
    public async Task<List<Product>> GetDiscountedProductsInStockAsync()
    {
        await Task.CompletedTask;
        return [];
    }
}
