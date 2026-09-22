using Microsoft.EntityFrameworkCore;

namespace LinqWhereCountEfBeginner;

public class StudentQueryService
{
    private readonly AppDbContext _dbContext;

    public StudentQueryService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// Add vissza azokat a tanulókat az adatbázisból, akik sikeresen teljesítettek.
    /// Egy tanuló akkor sikeres, ha a Grade értéke legalább 2.
    /// A service az AppDbContext-et dependency injectionből kapja, ezért az _dbContext.Students forráson használj Where szűrést és ToListAsync materializálást.
    /// </summary>
    public async Task<List<Student>> GetSuccessfulStudentsAsync()
    {
        Task <List<Student>> query = _dbContext.Students.AsQueryable().Where(s => s.Grade >= 2).ToListAsync();

        return await query;
    }

    /// <summary>
    /// Számold meg az adatbázisban lévő bukott tanulókat.
    /// Egy tanuló akkor bukott, ha a Grade értéke pontosan 1.
    /// A service az AppDbContext-et dependency injectionből kapja, ezért az _dbContext.Students forráson használj CountAsync hívást, kézi számláló változó nélkül.
    /// </summary>
    public async Task<int> CountFailedStudentsAsync()
    {
        Task<int> query = _dbContext.Students.AsQueryable().CountAsync(s => s.Grade == 1);

        return await query;
    }

    /// <summary>
    /// Add vissza az adatbázisból az aktív tanulókat.
    /// Az aktív tanulókat az IsActive mező true értéke jelöli.
    /// A service az AppDbContext-et dependency injectionből kapja, ezért az _dbContext.Students forráson használj Where szűrést és ToListAsync materializálást.
    /// </summary>
    public async Task<List<Student>> GetActiveStudentsAsync()
    {
        Task<List<Student>> query = _dbContext.Students.AsQueryable().Where(s => s.IsActive).ToListAsync();

        return await query;
    }

    /// <summary>
    /// Számold meg, hány tanuló lakik a paraméterben kapott városban.
    /// A city paramétert a Student.City mezővel hasonlítsd össze.
    /// A service az AppDbContext-et dependency injectionből kapja, ezért az _dbContext.Students forráson használj CountAsync hívást, kézi számláló változó nélkül.
    /// </summary>
    public async Task<int> CountStudentsInCityAsync(string city)
    {
        Task<int> query = _dbContext.Students.AsQueryable().CountAsync(s => s.City.ToLower() == city.ToLower());

        return await query;
    }
}
