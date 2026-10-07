using System.Collections;
using System.Reflection;
using TaskChecker.Grading;

internal static class Grader
{
    public static IReadOnlyList<TaskScore> Grade(Assembly examAssembly, GradingDetailMode detailMode)
    {
        IReadOnlyList<TaskScore> scores =
        [
            ScoreGoodStudentNames(examAssembly),
            ScoreProductsInStock(examAssembly),
            ScorePopularBookTitles(examAssembly),
            ScoreSuccessfulExamAverage(examAssembly),
            ScoreAffordableProductNames(examAssembly),
            ScoreBestScorerName(examAssembly),
            ScoreValuableStockTotal(examAssembly),
            ScoreImportantProjectNames(examAssembly)
        ];

        return scores;
    }

    private static TaskScore ScoreGoodStudentNames(Assembly assembly)
    {
        List<Student> students =
        [
            new("Anna", 4.6),
            new("Bela", 3.8),
            new("Csilla", 4.0),
            new("David", 2.9)
        ];

        List<Student> orderedBoundaryStudents =
        [
            new("Eva", 4.0),
            new("Feri", 3.99),
            new("Gina", 5.0)
        ];

        return ReflectionStaticClassGrader
            .ForTask(assembly, "SummaryTasks", "linq-summary-exam.good-student-names", "Jo tanulok", 3)
            .Check(type => SameItems(Invoke(type, "GetGoodStudentNames", students), ["Anna", "Csilla"]), 1.5m, "Csak a legalabb 4.0 atlagu tanulokat valasztja ki.")
            .Check(type => SameSequence(Invoke(type, "GetGoodStudentNames", orderedBoundaryStudents), ["Eva", "Gina"]), 1.5m, "Csak a neveket adja vissza, az eredeti sorrendben.")
            .Build();
    }

    private static TaskScore ScoreProductsInStock(Assembly assembly)
    {
        List<Product> boundaryProducts =
        [
            new("Out", "A", 100, 0),
            new("One", "A", 100, 1),
            new("Many", "A", 100, 2)
        ];

        List<Product> stockSumTrapProducts =
        [
            new("Keyboard", "IT", 12000, 8),
            new("Mouse", "IT", 6000, 0),
            new("Monitor", "IT", 65000, 4),
            new("Chair", "Office", 48000, 5),
            new("Desk", "Office", 55000, 2)
        ];

        return ReflectionStaticClassGrader
            .ForTask(assembly, "SummaryTasks", "linq-summary-exam.count-products-in-stock", "Keszleten levo termekek", 3)
            .Check(type => EqualsValue(Invoke(type, "CountProductsInStock", boundaryProducts), 2), 1.5m, "A Stock >= 1 feltetelt hasznalja.")
            .Check(type => EqualsValue(Invoke(type, "CountProductsInStock", stockSumTrapProducts), 4), 1.5m, "A megfelelo termekek darabszamat adja vissza.")
            .Build();
    }

    private static TaskScore ScorePopularBookTitles(Assembly assembly)
    {
        List<Book> books =
        [
            new("Dune", 24),
            new("Solaris", 9),
            new("1984", 31),
            new("Foundation", 15)
        ];

        List<Book> projectionBooks =
        [
            new("Book A", 10),
            new("Book B", 11),
            new("Book C", 9)
        ];

        return ReflectionStaticClassGrader
            .ForTask(assembly, "SummaryTasks", "linq-summary-exam.popular-book-titles", "Nepszeru konyvek", 4)
            .Check(type => SameItems(Invoke(type, "GetPopularBookTitles", books), ["Dune", "1984", "Foundation"]), 1, "Csak a legalabb 10 alkalommal kolcsonzott konyveket valasztja ki.")
            .Check(type => SameItems(Invoke(type, "GetPopularBookTitles", projectionBooks), ["Book A", "Book B"]), 1, "Csak a konyvcimeket adja vissza.")
            .Check(type => SameSequence(Invoke(type, "GetPopularBookTitles", books), ["1984", "Dune", "Foundation"]), 2, "A konyveket kolcsonzesszam szerint csokkeno sorrendben adja vissza.")
            .Build();
    }

    private static TaskScore ScoreSuccessfulExamAverage(Assembly assembly)
    {
        List<ExamResult> mixedResults =
        [
            new("Anna", 82),
            new("Bela", 45),
            new("Csilla", 70),
            new("David", 50)
        ];

        List<ExamResult> boundaryResults =
        [
            new("Eva", 50),
            new("Feri", 100)
        ];

        List<ExamResult> failedResults =
        [
            new("Hanna", 12),
            new("Imre", 49)
        ];

        return ReflectionStaticClassGrader
            .ForTask(assembly, "SummaryTasks", "linq-summary-exam.successful-exam-average", "Sikeres dolgozatok atlaga", 4)
            .Check(type => NumberEquals(Invoke(type, "GetSuccessfulExamAverage", boundaryResults), 75d), 1, "Csak a legalabb 50 pontos dolgozatokat veszi figyelembe.")
            .Check(type => NumberEquals(Invoke(type, "GetSuccessfulExamAverage", mixedResults), 67.3333333333d), 2, "A sikeres dolgozatok atlagpontszamat szamolja.")
            .Check(type =>
                NumberEquals(Invoke(type, "GetSuccessfulExamAverage", mixedResults), 67.3333333333d) &&
                NumberEquals(Invoke(type, "GetSuccessfulExamAverage", failedResults), 0d),
                1,
                "Ha nincs sikeres dolgozat, 0 erteket ad vissza.")
            .Build();
    }

    private static TaskScore ScoreAffordableProductNames(Assembly assembly)
    {
        List<Product> products =
        [
            new("Keyboard", "IT", 12000, 8),
            new("Mouse", "IT", 6000, 0),
            new("Monitor", "IT", 65000, 4),
            new("Chair", "Office", 48000, 5),
            new("Desk", "Office", 55000, 2)
        ];

        List<Product> boundaryProducts =
        [
            new("Cheap", "Audio", 49999, 1),
            new("Limit", "Audio", 50000, 1),
            new("Expensive", "Audio", 50001, 1),
            new("OtherCheap", "Other", 1000, 1)
        ];

        return ReflectionStaticClassGrader
            .ForTask(assembly, "SummaryTasks", "linq-summary-exam.affordable-product-names", "Megfizetheto termekek", 5)
            .Check(type => SameItems(Invoke(type, "GetAffordableProductNames", products, "Office"), ["Chair"]), 1, "Csak a parameterben kapott kategoriaba tartozo termekeket veszi figyelembe.")
            .Check(type => SameItems(Invoke(type, "GetAffordableProductNames", boundaryProducts, "Audio"), ["Cheap"]), 1, "Csak az 50000 Ft-nal olcsobb termekeket adja vissza.")
            .Check(type => SameSequence(Invoke(type, "GetAffordableProductNames", products, "IT"), ["Mouse", "Keyboard"]), 2, "A megfelelo termekeket ar szerint novekvo sorrendben adja vissza.")
            .Check(type => SameItems(Invoke(type, "GetAffordableProductNames", products, "IT"), ["Keyboard", "Mouse"]), 1, "Csak a termekneveket adja vissza.")
            .Build();
    }

    private static TaskScore ScoreBestScorerName(Assembly assembly)
    {
        List<Player> players =
        [
            new("Adam", 8, 5),
            new("Bence", 4, 9),
            new("Csaba", 10, 7),
            new("Daniel", 6, 3)
        ];

        List<Player> boundaryPlayers =
        [
            new("Eva", 5, 8),
            new("Feri", 8, 4),
            new("Gina", 4, 20)
        ];

        List<Player> shortPlayers =
        [
            new("Hanna", 1, 20),
            new("Imre", 4, 9)
        ];

        return ReflectionStaticClassGrader
            .ForTask(assembly, "SummaryTasks", "linq-summary-exam.best-scorer-name", "Legjobb gollo", 6)
            .Check(type => EqualsValue(Invoke(type, "GetBestScorerName", boundaryPlayers), "Eva"), 1, "Csak a legalabb 5 meccsen jatszo jatekosokat veszi figyelembe.")
            .Check(type => EqualsValue(Invoke(type, "GetBestScorerName", players), "Csaba"), 2, "A szurt jatekosok kozul a legtobb golt szerzot valasztja.")
            .Check(type => Invoke(type, "GetBestScorerName", players) is string, 1, "A jatekos nevet adja vissza.")
            .Check(type =>
                EqualsValue(Invoke(type, "GetBestScorerName", players), "Csaba") &&
                Invoke(type, "GetBestScorerName", shortPlayers) is null,
                2,
                "Ha nincs legalabb 5 meccses jatekos, null erteket ad vissza.")
            .Build();
    }

    private static TaskScore ScoreValuableStockTotal(Assembly assembly)
    {
        List<WarehouseItem> mixedItems =
        [
            new("Cable", 1200, 10),
            new("Adapter", 3500, 4),
            new("Monitor", 65000, 6),
            new("Pen", 300, 100)
        ];

        List<WarehouseItem> quantityItems =
        [
            new("Good", 1000, 5),
            new("TooFew", 90000, 4)
        ];

        List<WarehouseItem> priceItems =
        [
            new("Good", 1000, 5),
            new("TooCheap", 999, 100)
        ];

        List<WarehouseItem> noMatchItems =
        [
            new("Pen", 300, 100),
            new("Adapter", 3500, 4)
        ];

        return ReflectionStaticClassGrader
            .ForTask(assembly, "SummaryTasks", "linq-summary-exam.valuable-stock-total", "Ertekes raktarkeszlet", 7)
            .Check(type => EqualsValue(Invoke(type, "GetValuableStockTotal", quantityItems), 5000), 1, "Csak a legalabb 5 darabos tetelek szamitanak.")
            .Check(type => EqualsValue(Invoke(type, "GetValuableStockTotal", priceItems), 5000), 1, "Csak a legalabb 1000 Ft egysegaru tetelek szamitanak.")
            .Check(type => EqualsValue(Invoke(type, "GetValuableStockTotal", mixedItems), 402000), 2, "Tetelenkent UnitPrice * Quantity erteket szamol.")
            .Check(type =>
                EqualsValue(Invoke(type, "GetValuableStockTotal", mixedItems), 402000) &&
                EqualsValue(Invoke(type, "GetValuableStockTotal", noMatchItems), 0),
                3,
                "A megfelelo tetelek keszleterteket osszeadja, talalat nelkul 0-t ad.")
            .Build();
    }

    private static TaskScore ScoreImportantProjectNames(Assembly assembly)
    {
        List<ProjectInfo> sampleProjects =
        [
            new("Website", [new("Design", 8, true), new("Frontend", 12, false), new("Backend", 16, false)]),
            new("MobileApp", [new("UI", 6, true), new("API", 8, true), new("Testing", 5, true)]),
            new("Warehouse", [new("Database", 10, true), new("API", 15, false), new("Reports", 8, false), new("Deploy", 4, false)])
        ];

        List<ProjectInfo> taskCountProjects =
        [
            new("Boundary", [new("A", 5, true), new("B", 7, false), new("C", 8, true)]),
            new("TwoTasks", [new("A", 15, false), new("B", 15, true)])
        ];

        List<ProjectInfo> incompleteProjects =
        [
            new("Boundary", [new("A", 5, true), new("B", 7, false), new("C", 8, true)]),
            new("AllDone", [new("A", 10, true), new("B", 10, true), new("C", 10, true)])
        ];

        List<ProjectInfo> estimatedHourProjects =
        [
            new("Boundary", [new("A", 5, true), new("B", 7, false), new("C", 8, true)]),
            new("TooShort", [new("A", 6, false), new("B", 6, true), new("C", 6, true)])
        ];

        List<ProjectInfo> emptyProjects =
        [
            new("TwoTasks", [new("A", 15, false), new("B", 15, true)]),
            new("AllDone", [new("A", 10, true), new("B", 10, true), new("C", 10, true)]),
            new("TooShort", [new("A", 6, false), new("B", 6, true), new("C", 6, true)])
        ];

        return ReflectionStaticClassGrader
            .ForTask(assembly, "SummaryTasks", "linq-summary-exam.important-project-names", "Fontos projektek", 8)
            .Check(type => SameItems(Invoke(type, "GetImportantProjectNames", taskCountProjects), ["Boundary"]), 1, "Csak a legalabb 3 feladatos projekteket veszi figyelembe.")
            .Check(type => SameItems(Invoke(type, "GetImportantProjectNames", incompleteProjects), ["Boundary"]), 1, "Csak azokat a projekteket veszi figyelembe, ahol van befejezetlen feladat.")
            .Check(type => SameItems(Invoke(type, "GetImportantProjectNames", estimatedHourProjects), ["Boundary"]), 1, "Csak a legalabb 20 osszes becsult oraju projekteket veszi figyelembe.")
            .Check(type => SameSequence(Invoke(type, "GetImportantProjectNames", sampleProjects), ["Warehouse", "Website"]), 2, "A fontos projekteket osszes becsult munkaido szerint csokkeno sorrendben adja vissza.")
            .Check(type => SameItems(Invoke(type, "GetImportantProjectNames", sampleProjects), ["Website", "Warehouse"]), 1, "Csak a projektneveket adja vissza.")
            .Check(type =>
                SameSequence(Invoke(type, "GetImportantProjectNames", sampleProjects), ["Warehouse", "Website"]) &&
                SameSequence(Invoke(type, "GetImportantProjectNames", emptyProjects), []),
                2,
                "Ha nincs fontos projekt, ures listat ad vissza.")
            .Build();
    }

    private static object? Invoke(Type type, string methodName, params object?[] args)
    {
        try
        {
            MethodInfo? method = type.GetMethods(BindingFlags.Public | BindingFlags.Static)
                .FirstOrDefault(item => item.Name == methodName && item.GetParameters().Length == args.Length);

            return method?.Invoke(null, args);
        }
        catch
        {
            return null;
        }
    }

    private static bool SameItems(object? actual, IReadOnlyList<string> expected)
    {
        List<string>? actualItems = ToStringList(actual);
        return actualItems is not null &&
            actualItems.Count == expected.Count &&
            actualItems.OrderBy(item => item, StringComparer.Ordinal)
                .SequenceEqual(expected.OrderBy(item => item, StringComparer.Ordinal), StringComparer.Ordinal);
    }

    private static bool SameSequence(object? actual, IReadOnlyList<string> expected)
    {
        List<string>? actualItems = ToStringList(actual);
        return actualItems is not null &&
            actualItems.SequenceEqual(expected, StringComparer.Ordinal);
    }

    private static List<string>? ToStringList(object? value)
    {
        if (value is string)
            return null;

        if (value is not IEnumerable enumerable)
            return null;

        List<string> items = [];
        foreach (object? item in enumerable)
        {
            if (item is not string text)
                return null;

            items.Add(text);
        }

        return items;
    }

    private static bool EqualsValue(object? actual, object? expected)
    {
        return Equals(actual, expected);
    }

    private static bool NumberEquals(object? actual, double expected)
    {
        try
        {
            double value = Convert.ToDouble(actual);
            return Math.Abs(value - expected) <= 0.0001d;
        }
        catch
        {
            return false;
        }
    }
}
