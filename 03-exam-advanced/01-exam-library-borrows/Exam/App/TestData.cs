namespace LinqWhereCountEfAdvancedLibrary;

public static class TestData
{
    public static void Seed(AppDbContext db)
    {
        var anna = new Reader { Id = 1, Name = "Anna" };
        var bela = new Reader { Id = 2, Name = "Bela" };
        var csilla = new Reader { Id = 3, Name = "Csilla" };

        db.Readers.AddRange(anna, bela, csilla);
        db.BorrowRecords.AddRange(
            new BorrowRecord { Id = 1, ReaderId = 1, BookTitle = "C# Basics", IsOverdue = false },
            new BorrowRecord { Id = 2, ReaderId = 1, BookTitle = "Clean Code", IsOverdue = true },
            new BorrowRecord { Id = 3, ReaderId = 1, BookTitle = "Clean Code", IsOverdue = false },
            new BorrowRecord { Id = 4, ReaderId = 2, BookTitle = "SQL Intro", IsOverdue = true }
        );
        db.SaveChanges();
    }
}