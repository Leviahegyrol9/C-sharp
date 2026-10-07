using System.Collections.Generic;
using System.Linq;

public static class SummaryTasks
{
    // =========================
    // KONNYU FELADATOK
    // =========================

    /// <summary>
    /// 1. feladat - Jo tanulok (3 pont)
    /// Add vissza azoknak a tanuloknak a nevet, akiknek az atlaga legalabb 4.0.
    /// Hasznalj Where es Select muveleteket.
    /// </summary>
    public static List<string> GetGoodStudentNames(List<Student> students) => students.Where(s => s.Average >= 4).Select(s => s.Name).ToList();

    /// <summary>
    /// 2. feladat - Keszleten levo termekek szama (3 pont)
    /// Add vissza, hany olyan termek van, amelybol legalabb 1 darab van keszleten.
    /// Hasznalj Count muveletet.
    /// </summary>
    public static int CountProductsInStock(List<Product> products) => products.Count(p => p.Stock >= 1);

    // =========================
    // KOZEPES FELADATOK
    // =========================

    /// <summary>
    /// 3. feladat - Nepszeru konyvek (4 pont)
    /// Add vissza azoknak a konyveknek a cimet, amelyeket legalabb 10 alkalommal kolcsonoztek.
    /// A cimeket a kolcsonzesek szama szerint csokkeno sorrendben add vissza.
    /// Hasznalj Where, OrderByDescending es Select muveleteket.
    /// </summary>
    public static List<string> GetPopularBookTitles(List<Book> books) => books.Where(b => b.BorrowCount >= 10).OrderByDescending(b => b.BorrowCount).Select(b => b.Title).ToList();

    /// <summary>
    /// 4. feladat - Sikeres dolgozatok atlaga (4 pont)
    /// Szamitsd ki azoknak a dolgozatoknak az atlagpontszamat, amelyek legalabb 50 pontosak.
    /// Ha nincs sikeres dolgozat, az eredmeny legyen 0.
    /// Hasznalj Where es Average muveleteket.
    /// </summary>
    public static double GetSuccessfulExamAverage(List<ExamResult> results) => results.Where(e => e.Points >= 50).Average(e => e.Points);

    /// <summary>
    /// 5. feladat - Megfizetheto termekek (5 pont)
    /// Add vissza az adott kategoriaba tartozo, 50000 Ft-nal olcsobb termekek neveit
    /// ar szerint novekvo sorrendben.
    /// Hasznalj Where, OrderBy es Select muveleteket.
    /// </summary>
    public static List<string> GetAffordableProductNames(List<Product> products, string category) => products.Where(p => p.Category == category && p.Price < 50000).OrderBy(p => p.Price).Select(p => p.Name).ToList();

    // =========================
    // KOZEPES-NEHEZ FELADATOK
    // =========================

    /// <summary>
    /// 6. feladat - Legjobb gollo (6 pont)
    /// Add vissza annak a jatekosnak a nevet, aki a legtobb golt szerezte azok kozul,
    /// akik legalabb 5 merkozesen jatszottak. Ha nincs ilyen jatekos, adj vissza null erteket.
    /// Hasznalj Where, OrderByDescending es FirstOrDefault muveleteket.
    /// </summary>
    public static string? GetBestScorerName(List<Player> players) => players.Where(p => p.Matches >= 5).OrderByDescending(p => p.Goals).Select(p => p.Name).FirstOrDefault();

    /// <summary>
    /// 7. feladat - Ertekes raktarkeszlet (7 pont)
    /// Szamitsd ki azoknak a termekeknek a teljes keszleterteket (UnitPrice * Quantity),
    /// amelyekbol legalabb 5 darab van raktaron, es az egysegaruk legalabb 1000 Ft.
    /// Hasznalj Where es Sum muveleteket.
    /// </summary>
    public static int GetValuableStockTotal(List<WarehouseItem> items) => items.Where(i => i.Quantity >= 5 && i.UnitPrice >= 1000).Sum(i => i.Quantity * i.UnitPrice);

    // =========================
    // NEHEZ FELADAT
    // =========================

    /// <summary>
    /// 8. feladat - Fontos projektek (8 pont)
    /// Add vissza azoknak a projekteknek a neveit, amelyeknek legalabb 3 feladatuk van,
    /// van legalabb egy befejezetlen feladatuk, es az osszes feladat becsult munkaideje
    /// legalabb 20 ora. A megfelelo projekteket az osszes becsult munkaido szerint
    /// csokkeno sorrendben add vissza.
    /// Hasznalj Where, Any, Sum, OrderByDescending es Select muveleteket.
    /// </summary>
    public static List<string> GetImportantProjectNames(List<ProjectInfo> projects) => projects.Where(p => p.Tasks.Count >= 3 && p.Tasks.Any(t => !t.Completed) && p.Tasks.Sum(e => e.EstimatedHours) >= 20).OrderByDescending(p => p.Tasks.Sum(e => e.EstimatedHours)).Select(p => p.Name).ToList();
}
