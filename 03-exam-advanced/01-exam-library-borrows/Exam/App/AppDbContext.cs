using Microsoft.EntityFrameworkCore;

namespace LinqWhereCountEfAdvancedLibrary;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Reader> Readers => Set<Reader>();
    public DbSet<BorrowRecord> BorrowRecords => Set<BorrowRecord>();
}