using System.Reflection;
using TaskChecker.Grading;

internal static class Grader
{
    private const string TaskNamespace = "CSharpGyakorloFeladatsor";
    private const string TaskClassName = "Feladatok";

    public static IReadOnlyList<TaskScore> Grade(Assembly assembly, PilotMode pilotMode)
    {
        return
        [
            GradeParosSzamjegyekSzama(assembly, pilotMode),
            GradeKarakterDarab(assembly, pilotMode),
            GradeNegativakOsszege(assembly, pilotMode),
            GradeUtolsoPozitivIndexe(assembly, pilotMode),
            GradeErvenyesFelhasznalonev(assembly, pilotMode),
            GradeLegolcsobbTermek(assembly, pilotMode),
            GradePontKategoriak(assembly, pilotMode),
            GradeMasodikLegnagyobbKulonbozo(assembly, pilotMode),
            GradeLegnagyobbOsszeguOszlop(assembly, pilotMode),
            GradeLeghosszabbAzonosSzakasz(assembly, pilotMode)
        ];
    }

    private static TaskScore GradeParosSzamjegyekSzama(Assembly assembly, PilotMode pilotMode)
    {
        return ForTask(assembly, "array-methods.01-02.even-digit-count", "Paros szamjegyek szama", 8)
            .HasPublicStaticClass(0, "A Feladatok osztaly public static class.", Diagnostics(pilotMode, "array-methods.01-02.class.static", ["static-class"], "Feladatok public static class", 0))
            .HasPublicStaticMethod<int>(
                "ParosSzamjegyekSzama",
                0,
                "Megvan a public static int ParosSzamjegyekSzama(int szam) metodus.",
                Diagnostics(pilotMode, "array-methods.01-02.even-digit-count.signature", ["method.signature", "number"], "ParosSzamjegyekSzama signature", 0),
                typeof(int))
            .MethodReturnsForEachCase(
                "ParosSzamjegyekSzama",
                [
                    MethodCase.Args(583204).Returns(3),
                    MethodCase.Args(0).Returns(1),
                    MethodCase.Args(13579).Returns(0),
                    MethodCase.Args(2468).Returns(4),
                    MethodCase.Args(1002003).Returns(5)
                ],
                8,
                "A ParosSzamjegyekSzama helyesen szamolja a paros szamjegyeket.",
                Diagnostics(pilotMode, "array-methods.01-02.even-digit-count.behavior", ["number.digits", "counting"], "Paros szamjegyek szamlalasa", 8),
                typeof(int))
            .Build();
    }

    private static TaskScore GradeKarakterDarab(Assembly assembly, PilotMode pilotMode)
    {
        return ForTask(assembly, "array-methods.01-02.char-count", "Karakter darab", 8)
            .HasPublicStaticClass(0, "A Feladatok osztaly public static class.", Diagnostics(pilotMode, "array-methods.01-02.char-count.class.static", ["static-class"], "Feladatok public static class", 0))
            .HasPublicStaticMethod<int>(
                "KarakterDarab",
                0,
                "Megvan a public static int KarakterDarab(string szoveg, char karakter) metodus.",
                Diagnostics(pilotMode, "array-methods.01-02.char-count.signature", ["method.signature", "string"], "KarakterDarab signature", 0),
                typeof(string), typeof(char))
            .MethodReturnsForEachCase(
                "KarakterDarab",
                [
                    MethodCase.Args("programozas", 'o').Returns(2),
                    MethodCase.Args("", 'a').Returns(0),
                    MethodCase.Args("aaaa", 'a').Returns(4),
                    MethodCase.Args("Alma alma", 'a').Returns(2),
                    MethodCase.Args("Alma alma", 'A').Returns(1)
                ],
                8,
                "A KarakterDarab helyesen szamolja a megadott karakter elofordulasait.",
                Diagnostics(pilotMode, "array-methods.01-02.char-count.behavior", ["string.traversal", "counting"], "Karakter elofordulas szamlalasa", 8),
                typeof(string), typeof(char))
            .Build();
    }

    private static TaskScore GradeNegativakOsszege(Assembly assembly, PilotMode pilotMode)
    {
        return ForTask(assembly, "array-methods.01-02.negative-sum", "Negativak osszege", 8)
            .HasPublicStaticClass(0, "A Feladatok osztaly public static class.", Diagnostics(pilotMode, "array-methods.01-02.negative-sum.class.static", ["static-class"], "Feladatok public static class", 0))
            .HasPublicStaticMethod<int>(
                "NegativakOsszege",
                0,
                "Megvan a public static int NegativakOsszege(int[] szamok) metodus.",
                Diagnostics(pilotMode, "array-methods.01-02.negative-sum.signature", ["method.signature", "array"], "NegativakOsszege signature", 0),
                typeof(int[]))
            .MethodReturnsForEachCase(
                "NegativakOsszege",
                [
                    MethodCase.Args(new[] { 4, -3, 8, -5, -2 }).Returns(-10),
                    MethodCase.Args(Array.Empty<int>()).Returns(0),
                    MethodCase.Args(new[] { 1, 2, 3 }).Returns(0),
                    MethodCase.Args(new[] { -1, -2, -3 }).Returns(-6),
                    MethodCase.Args(new[] { -10, 0, 10, -5 }).Returns(-15)
                ],
                8,
                "A NegativakOsszege helyesen adja ossze a negativ elemeket.",
                Diagnostics(pilotMode, "array-methods.01-02.negative-sum.behavior", ["array.traversal", "conditional-sum"], "Negativ elemek osszegzese", 8),
                typeof(int[]))
            .Build();
    }

    private static TaskScore GradeUtolsoPozitivIndexe(Assembly assembly, PilotMode pilotMode)
    {
        return ForTask(assembly, "array-methods.01-02.last-positive-index", "Utolso pozitiv indexe", 8)
            .HasPublicStaticClass(0, "A Feladatok osztaly public static class.", Diagnostics(pilotMode, "array-methods.01-02.last-positive-index.class.static", ["static-class"], "Feladatok public static class", 0))
            .HasPublicStaticMethod<int>(
                "UtolsoPozitivIndexe",
                0,
                "Megvan a public static int UtolsoPozitivIndexe(int[] szamok) metodus.",
                Diagnostics(pilotMode, "array-methods.01-02.last-positive-index.signature", ["method.signature", "array"], "UtolsoPozitivIndexe signature", 0),
                typeof(int[]))
            .MethodReturnsForEachCase(
                "UtolsoPozitivIndexe",
                [
                    MethodCase.Args(new[] { -2, 5, -1, 8, 0, -3 }).Returns(3),
                    MethodCase.Args(Array.Empty<int>()).Returns(-1),
                    MethodCase.Args(new[] { 1, 2, 3 }).Returns(2),
                    MethodCase.Args(new[] { -1, 0, -2 }).Returns(-1),
                    MethodCase.Args(new[] { 7, -1, 0 }).Returns(0)
                ],
                8,
                "Az UtolsoPozitivIndexe helyesen keresi az utolso pozitiv elem indexet.",
                Diagnostics(pilotMode, "array-methods.01-02.last-positive-index.behavior", ["array.search", "condition"], "Utolso pozitiv elem keresese", 8),
                typeof(int[]))
            .Build();
    }

    private static TaskScore GradeErvenyesFelhasznalonev(Assembly assembly, PilotMode pilotMode)
    {
        return ForTask(assembly, "array-methods.01-02.username-validation", "Ervenyes felhasznalonev", 10)
            .HasPublicStaticClass(0, "A Feladatok osztaly public static class.", Diagnostics(pilotMode, "array-methods.01-02.username-validation.class.static", ["static-class"], "Feladatok public static class", 0))
            .HasPublicStaticMethod<bool>(
                "ErvenyesFelhasznalonev",
                0,
                "Megvan a public static bool ErvenyesFelhasznalonev(string nev) metodus.",
                Diagnostics(pilotMode, "array-methods.01-02.username-validation.signature", ["method.signature", "string.validation"], "ErvenyesFelhasznalonev signature", 0),
                typeof(string))
            .MethodReturnsForCases(
                "ErvenyesFelhasznalonev",
                [
                    MethodCase.Args("anna_25").Returns(true),
                    MethodCase.Args("Bela7").Returns(true),
                    MethodCase.Args("A1234").Returns(true),
                    MethodCase.Args("abcde").Returns(true),
                    MethodCase.Args("abcdefgh1234").Returns(true),
                    MethodCase.Args("25anna").Returns(false),
                    MethodCase.Args("ab#cd").Returns(false),
                    MethodCase.Args("abc").Returns(false),
                    MethodCase.Args("abcdefghijkl3").Returns(false),
                    MethodCase.Args("_anna25").Returns(false)
                ],
                10,
                "Az ErvenyesFelhasznalonev csak akkor kap pontot, ha minden ervenyes es ervenytelen nevet helyesen ellenoriz.",
                Diagnostics(pilotMode, "array-methods.01-02.username-validation.behavior", ["string.validation", "char.check"], "Felhasznalonev validacio", 10),
                typeof(string))
            .Build();
    }

    private static TaskScore GradeLegolcsobbTermek(Assembly assembly, PilotMode pilotMode)
    {
        return ForTask(assembly, "array-methods.01-02.cheapest-product", "Legolcsobb termek", 10)
            .HasPublicStaticClass(0, "A Feladatok osztaly public static class.", Diagnostics(pilotMode, "array-methods.01-02.cheapest-product.class.static", ["static-class"], "Feladatok public static class", 0))
            .HasPublicStaticMethod<string>(
                "LegolcsobbTermek",
                0,
                "Megvan a public static string LegolcsobbTermek(string[] termekek, int[] arak) metodus.",
                Diagnostics(pilotMode, "array-methods.01-02.cheapest-product.signature", ["method.signature", "parallel-arrays"], "LegolcsobbTermek signature", 0),
                typeof(string[]), typeof(int[]))
            .MethodReturnsForEachCase(
                "LegolcsobbTermek",
                [
                    MethodCase.Args(new[] { "Eger", "Billentyuzet", "Pendrive" }, new[] { 6500, 8900, 4200 }).Returns("Pendrive"),
                    MethodCase.Args(new[] { "A" }, new[] { 100 }).Returns("A"),
                    MethodCase.Args(new[] { "A", "B" }, new[] { 50, 50 }).Returns("A"),
                    MethodCase.Args(new[] { "A", "B", "C" }, new[] { 300, 100, 200 }).Returns("B"),
                    MethodCase.Args(new[] { "A", "B", "C" }, new[] { 5, 3, 3 }).Returns("B")
                ],
                10,
                "A LegolcsobbTermek helyesen valasztja ki a legkisebb aru termeket.",
                Diagnostics(pilotMode, "array-methods.01-02.cheapest-product.behavior", ["parallel-arrays", "minimum-search"], "Legolcsobb termek keresese", 10),
                typeof(string[]), typeof(int[]))
            .Build();
    }

    private static TaskScore GradePontKategoriak(Assembly assembly, PilotMode pilotMode)
    {
        return ForTask(assembly, "array-methods.01-02.score-categories", "Pontkategoriak", 10)
            .HasPublicStaticClass(0, "A Feladatok osztaly public static class.", Diagnostics(pilotMode, "array-methods.01-02.score-categories.class.static", ["static-class"], "Feladatok public static class", 0))
            .HasPublicStaticMethod<int[]>(
                "PontKategoriak",
                0,
                "Megvan a public static int[] PontKategoriak(int[] pontok) metodus.",
                Diagnostics(pilotMode, "array-methods.01-02.score-categories.signature", ["method.signature", "array"], "PontKategoriak signature", 0),
                typeof(int[]))
            .MethodReturnsForEachCase(
                "PontKategoriak",
                [
                    MethodCase.Args(new[] { 42, 75, 91, 63, 80, 30 }).Returns(new[] { 2, 1, 1, 2 }),
                    MethodCase.Args(Array.Empty<int>()).Returns(new[] { 0, 0, 0, 0 }),
                    MethodCase.Args(new[] { 0, 49, 50, 64, 65, 79, 80, 100 }).Returns(new[] { 2, 2, 2, 2 }),
                    MethodCase.Args(new[] { 100, 100 }).Returns(new[] { 0, 0, 0, 2 }),
                    MethodCase.Args(new[] { 50, 65, 80 }).Returns(new[] { 0, 1, 1, 1 })
                ],
                10,
                "A PontKategoriak helyes gyakorisagi tombot keszit.",
                Diagnostics(pilotMode, "array-methods.01-02.score-categories.behavior", ["array.counting", "histogram"], "Pontszam kategoriak", 10),
                typeof(int[]))
            .Build();
    }

    private static TaskScore GradeMasodikLegnagyobbKulonbozo(Assembly assembly, PilotMode pilotMode)
    {
        return ForTask(assembly, "array-methods.01-02.second-largest-distinct", "Masodik legnagyobb kulonbozo", 10)
            .HasPublicStaticClass(0, "A Feladatok osztaly public static class.", Diagnostics(pilotMode, "array-methods.01-02.second-largest-distinct.class.static", ["static-class"], "Feladatok public static class", 0))
            .HasPublicStaticMethod<int>(
                "MasodikLegnagyobbKulonbozo",
                0,
                "Megvan a public static int MasodikLegnagyobbKulonbozo(int[] szamok) metodus.",
                Diagnostics(pilotMode, "array-methods.01-02.second-largest-distinct.signature", ["method.signature", "array"], "MasodikLegnagyobbKulonbozo signature", 0),
                typeof(int[]))
            .MethodReturnsForEachCase(
                "MasodikLegnagyobbKulonbozo",
                [
                    MethodCase.Args(new[] { 12, 7, 18, 5, 18, 14 }).Returns(14),
                    MethodCase.Args(new[] { 1, 2 }).Returns(1),
                    MethodCase.Args(new[] { 5, 5, 4 }).Returns(4),
                    MethodCase.Args(new[] { -10, -3, -7 }).Returns(-7),
                    MethodCase.Args(new[] { 100, 80, 100, 90 }).Returns(90)
                ],
                10,
                "A MasodikLegnagyobbKulonbozo helyesen kezeli az ismetlodo legnagyobb erteket is.",
                Diagnostics(pilotMode, "array-methods.01-02.second-largest-distinct.behavior", ["array.traversal", "maximum-search"], "Masodik legnagyobb kulonbozo ertek", 10),
                typeof(int[]))
            .Build();
    }

    private static TaskScore GradeLegnagyobbOsszeguOszlop(Assembly assembly, PilotMode pilotMode)
    {
        return ForTask(assembly, "array-methods.01-02.max-column-sum", "Legnagyobb osszegu oszlop", 14)
            .HasPublicStaticClass(0, "A Feladatok osztaly public static class.", Diagnostics(pilotMode, "array-methods.01-02.max-column-sum.class.static", ["static-class"], "Feladatok public static class", 0))
            .HasPublicStaticMethod<int>(
                "LegnagyobbOsszeguOszlop",
                0,
                "Megvan a public static int LegnagyobbOsszeguOszlop(int[,] matrix) metodus.",
                Diagnostics(pilotMode, "array-methods.01-02.max-column-sum.signature", ["method.signature", "matrix"], "LegnagyobbOsszeguOszlop signature", 0),
                typeof(int[,]))
            .MethodReturnsForEachCase(
                "LegnagyobbOsszeguOszlop",
                [
                    MethodCase.Args(new int[,] { { 3, 8, 1 }, { 4, 2, 7 }, { 2, 5, 3 } }).Returns(1),
                    MethodCase.Args(new int[,] { { 3, 3 }, { 2, 2 } }).Returns(0),
                    MethodCase.Args(new int[,] { { -5, -1 }, { -2, -2 } }).Returns(1),
                    MethodCase.Args(new int[,] { { 7 }, { 8 }, { 9 } }).Returns(0),
                    MethodCase.Args(new int[,] { { 1, 5, 3 } }).Returns(1)
                ],
                14,
                "A LegnagyobbOsszeguOszlop helyesen keresi a legnagyobb oszloposszeget.",
                Diagnostics(pilotMode, "array-methods.01-02.max-column-sum.behavior", ["matrix", "maximum-search"], "Legnagyobb oszloposszeg keresese", 14),
                typeof(int[,]))
            .Build();
    }

    private static TaskScore GradeLeghosszabbAzonosSzakasz(Assembly assembly, PilotMode pilotMode)
    {
        return ForTask(assembly, "array-methods.01-02.longest-equal-run", "Leghosszabb azonos szakasz", 14)
            .HasPublicStaticClass(0, "A Feladatok osztaly public static class.", Diagnostics(pilotMode, "array-methods.01-02.longest-equal-run.class.static", ["static-class"], "Feladatok public static class", 0))
            .HasPublicStaticMethod<int>(
                "LeghosszabbAzonosSzakasz",
                0,
                "Megvan a public static int LeghosszabbAzonosSzakasz(int[] szamok) metodus.",
                Diagnostics(pilotMode, "array-methods.01-02.longest-equal-run.signature", ["method.signature", "array"], "LeghosszabbAzonosSzakasz signature", 0),
                typeof(int[]))
            .MethodReturnsForEachCase(
                "LeghosszabbAzonosSzakasz",
                [
                    MethodCase.Args(new[] { 2, 2, 5, 5, 5, 1, 3, 3 }).Returns(3),
                    MethodCase.Args(new[] { 1 }).Returns(1),
                    MethodCase.Args(new[] { 1, 1, 1 }).Returns(3),
                    MethodCase.Args(new[] { 1, 2, 3 }).Returns(1),
                    MethodCase.Args(new[] { 4, 4, 2, 2, 2, 3, 3, 3 }).Returns(3),
                    MethodCase.Args(new[] { 5, 5, 1, 1, 1, 1, 2 }).Returns(4)
                ],
                14,
                "A LeghosszabbAzonosSzakasz helyesen meri a leghosszabb egymas melletti azonos szakaszt.",
                Diagnostics(pilotMode, "array-methods.01-02.longest-equal-run.behavior", ["array.traversal", "sequence"], "Leghosszabb azonos szakasz", 14),
                typeof(int[]))
            .Build();
    }

    private static ReflectionStaticClassGrader ForTask(
        Assembly assembly,
        string taskId,
        string title,
        decimal maxPoints)
    {
        return ReflectionStaticClassGrader.ForTask(assembly, TaskNamespace, TaskClassName, taskId, title, maxPoints);
    }

    private static CheckDiagnostics? Diagnostics(
        PilotMode pilotMode,
        string checkId,
        IReadOnlyList<string> learningOutcomeIds,
        string title,
        decimal weight)
    {
        if (pilotMode == PilotMode.Basic110)
            return null;

        return CheckDiagnostics.For(checkId, learningOutcomeIds, title, weight);
    }
}
