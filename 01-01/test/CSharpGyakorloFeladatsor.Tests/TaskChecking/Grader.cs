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
            GradeNagybetukSzama(assembly, pilotMode),
            GradeSzamjegyekOsszege(assembly, pilotMode),
            GradeHatarFelettiDarab(assembly, pilotMode),
            GradeElsoParosIndexe(assembly, pilotMode),
            GradeErvenyesTermekkod(assembly, pilotMode),
            GradeLegjobbTanulo(assembly, pilotMode),
            GradeJegyHisztogram(assembly, pilotMode),
            GradeLegnagyobbOsszeguSor(assembly, pilotMode),
            GradeLeghosszabbNovekvoSzakasz(assembly, pilotMode)
        ];
    }

    private static TaskScore GradeNagybetukSzama(Assembly assembly, PilotMode pilotMode)
    {
        return ForTask(assembly, "array-methods.01.uppercase-count", "Nagybetuk szama", 10)
            .HasPublicStaticClass(
                0,
                "A Feladatok osztaly public static class.",
                Diagnostics(pilotMode, "array-methods.01.class.static", ["static-class"], "Feladatok public static class", 0))
            .HasPublicStaticMethod<int>(
                "NagybetukSzama",
                0,
                "Megvan a public static int NagybetukSzama(string szoveg) metodus.",
                Diagnostics(pilotMode, "array-methods.01.uppercase-count.signature", ["method.signature", "string"], "NagybetukSzama signature", 0),
                typeof(string))
            .MethodReturnsForEachCase(
                "NagybetukSzama",
                [
                    MethodCase.Args("AlmaFA").Returns(3),
                    MethodCase.Args("").Returns(0),
                    MethodCase.Args("alma").Returns(0),
                    MethodCase.Args("ABC").Returns(3),
                    MethodCase.Args("A1 bC!").Returns(2)
                ],
                10,
                "A NagybetukSzama helyes eredmenyt ad kulonbozo szovegekre.",
                Diagnostics(pilotMode, "array-methods.01.uppercase-count.behavior", ["string.traversal", "char.check"], "Nagybetuk szamlalasa", 10),
                typeof(string))
            .Build();
    }

    private static TaskScore GradeSzamjegyekOsszege(Assembly assembly, PilotMode pilotMode)
    {
        return ForTask(assembly, "array-methods.02.digit-sum", "Szamjegyek osszege", 10)
            .HasPublicStaticClass(0, "A Feladatok osztaly public static class.", Diagnostics(pilotMode, "array-methods.02.class.static", ["static-class"], "Feladatok public static class", 0))
            .HasPublicStaticMethod<int>(
                "SzamjegyekOsszege",
                0,
                "Megvan a public static int SzamjegyekOsszege(int szam) metodus.",
                Diagnostics(pilotMode, "array-methods.02.digit-sum.signature", ["method.signature", "number"], "SzamjegyekOsszege signature", 0),
                typeof(int))
            .MethodReturnsForEachCase(
                "SzamjegyekOsszege",
                [
                    MethodCase.Args(472).Returns(13),
                    MethodCase.Args(0).Returns(0),
                    MethodCase.Args(1005).Returns(6),
                    MethodCase.Args(99999).Returns(45),
                    MethodCase.Args(2000000000).Returns(2)
                ],
                10,
                "A SzamjegyekOsszege helyes eredmenyt ad szelso es atlagos esetekre.",
                Diagnostics(pilotMode, "array-methods.02.digit-sum.behavior", ["number.digits", "loop"], "Szamjegyek osszege", 10),
                typeof(int))
            .Build();
    }

    private static TaskScore GradeHatarFelettiDarab(Assembly assembly, PilotMode pilotMode)
    {
        return ForTask(assembly, "array-methods.03.count-above-limit", "Hatar feletti darab", 10)
            .HasPublicStaticClass(0, "A Feladatok osztaly public static class.", Diagnostics(pilotMode, "array-methods.03.class.static", ["static-class"], "Feladatok public static class", 0))
            .HasPublicStaticMethod<int>(
                "HatarFelettiDarab",
                0,
                "Megvan a public static int HatarFelettiDarab(int[] szamok, int hatar) metodus.",
                Diagnostics(pilotMode, "array-methods.03.count-above-limit.signature", ["method.signature", "array"], "HatarFelettiDarab signature", 0),
                typeof(int[]), typeof(int))
            .MethodReturnsForEachCase(
                "HatarFelettiDarab",
                [
                    MethodCase.Args(new[] { 12, 7, 19, 10 }, 10).Returns(2),
                    MethodCase.Args(Array.Empty<int>(), 10).Returns(0),
                    MethodCase.Args(new[] { 5, 5, 5 }, 5).Returns(0),
                    MethodCase.Args(new[] { 6, 6, 6 }, 5).Returns(3),
                    MethodCase.Args(new[] { -2, 0, 3 }, -1).Returns(2)
                ],
                10,
                "A HatarFelettiDarab helyesen megszamolja a hatar feletti elemeket.",
                Diagnostics(pilotMode, "array-methods.03.count-above-limit.behavior", ["array.traversal", "counting"], "Hatar feletti elemek szamlalasa", 10),
                typeof(int[]), typeof(int))
            .Build();
    }

    private static TaskScore GradeElsoParosIndexe(Assembly assembly, PilotMode pilotMode)
    {
        return ForTask(assembly, "array-methods.04.first-even-index", "Elso paros indexe", 10)
            .HasPublicStaticClass(0, "A Feladatok osztaly public static class.", Diagnostics(pilotMode, "array-methods.04.class.static", ["static-class"], "Feladatok public static class", 0))
            .HasPublicStaticMethod<int>(
                "ElsoParosIndexe",
                0,
                "Megvan a public static int ElsoParosIndexe(int[] szamok) metodus.",
                Diagnostics(pilotMode, "array-methods.04.first-even-index.signature", ["method.signature", "array"], "ElsoParosIndexe signature", 0),
                typeof(int[]))
            .MethodReturnsForEachCase(
                "ElsoParosIndexe",
                [
                    MethodCase.Args(new[] { 5, 9, 8, 2 }).Returns(2),
                    MethodCase.Args(Array.Empty<int>()).Returns(-1),
                    MethodCase.Args(new[] { 2, 4, 6 }).Returns(0),
                    MethodCase.Args(new[] { 1, 3, 5 }).Returns(-1),
                    MethodCase.Args(new[] { 7, 11, 14 }).Returns(2)
                ],
                10,
                "Az ElsoParosIndexe helyesen keresi az elso paros elem indexet.",
                Diagnostics(pilotMode, "array-methods.04.first-even-index.behavior", ["array.search", "condition"], "Elso paros elem keresese", 10),
                typeof(int[]))
            .Build();
    }

    private static TaskScore GradeErvenyesTermekkod(Assembly assembly, PilotMode pilotMode)
    {
        return ForTask(assembly, "array-methods.05.product-code", "Ervenyes termekkod", 12)
            .HasPublicStaticClass(0, "A Feladatok osztaly public static class.", Diagnostics(pilotMode, "array-methods.05.class.static", ["static-class"], "Feladatok public static class", 0))
            .HasPublicStaticMethod<bool>(
                "ErvenyesTermekkod",
                0,
                "Megvan a public static bool ErvenyesTermekkod(string kod) metodus.",
                Diagnostics(pilotMode, "array-methods.05.product-code.signature", ["method.signature", "string"], "ErvenyesTermekkod signature", 0),
                typeof(string))
            .MethodReturnsForCases(
                "ErvenyesTermekkod",
                [
                    MethodCase.Args("AB-2048").Returns(true),
                    MethodCase.Args("ZZ-0000").Returns(true),
                    MethodCase.Args("XY-9999").Returns(true),
                    MethodCase.Args("HU-1234").Returns(true),
                    MethodCase.Args("CD-0001").Returns(true),
                    MethodCase.Args("EF-9876").Returns(true),
                    MethodCase.Args("QA-2026").Returns(true),
                    MethodCase.Args("TT-5555").Returns(true),
                    MethodCase.Args("Ab-2048").Returns(false),
                    MethodCase.Args("AB2048").Returns(false),
                    MethodCase.Args("AB-20X8").Returns(false),
                    MethodCase.Args("AB-204").Returns(false)
                ],
                12,
                "Az ErvenyesTermekkod csak akkor kap pontot, ha minden ervenyes es ervenytelen kodot helyesen ellenoriz.",
                Diagnostics(pilotMode, "array-methods.05.product-code.behavior", ["string.validation", "char.check"], "Termekkod validacio", 12),
                typeof(string))
            .Build();
    }

    private static TaskScore GradeLegjobbTanulo(Assembly assembly, PilotMode pilotMode)
    {
        return ForTask(assembly, "array-methods.06.best-student", "Legjobb tanulo", 12)
            .HasPublicStaticClass(0, "A Feladatok osztaly public static class.", Diagnostics(pilotMode, "array-methods.06.class.static", ["static-class"], "Feladatok public static class", 0))
            .HasPublicStaticMethod<string>(
                "LegjobbTanulo",
                0,
                "Megvan a public static string LegjobbTanulo(string[] nevek, int[] pontok) metodus.",
                Diagnostics(pilotMode, "array-methods.06.best-student.signature", ["method.signature", "parallel-arrays"], "LegjobbTanulo signature", 0),
                typeof(string[]), typeof(int[]))
            .MethodReturnsForEachCase(
                "LegjobbTanulo",
                [
                    MethodCase.Args(new[] { "Anna", "Bela", "Cili" }, new[] { 70, 95, 80 }).Returns("Bela"),
                    MethodCase.Args(new[] { "Anna", "Bela" }, new[] { 90, 90 }).Returns("Anna"),
                    MethodCase.Args(new[] { "Egy" }, new[] { 42 }).Returns("Egy"),
                    MethodCase.Args(new[] { "A", "B", "C" }, new[] { 1, 3, 2 }).Returns("B")
                ],
                12,
                "A LegjobbTanulo helyesen valasztja ki a legnagyobb pontszamu tanulot.",
                Diagnostics(pilotMode, "array-methods.06.best-student.behavior", ["parallel-arrays", "maximum-search"], "Legjobb tanulo keresese", 12),
                typeof(string[]), typeof(int[]))
            .Build();
    }

    private static TaskScore GradeJegyHisztogram(Assembly assembly, PilotMode pilotMode)
    {
        return ForTask(assembly, "array-methods.07.grade-histogram", "Jegyhisztogram", 12)
            .HasPublicStaticClass(0, "A Feladatok osztaly public static class.", Diagnostics(pilotMode, "array-methods.07.class.static", ["static-class"], "Feladatok public static class", 0))
            .HasPublicStaticMethod<int[]>(
                "JegyHisztogram",
                0,
                "Megvan a public static int[] JegyHisztogram(int[] jegyek) metodus.",
                Diagnostics(pilotMode, "array-methods.07.grade-histogram.signature", ["method.signature", "array"], "JegyHisztogram signature", 0),
                typeof(int[]))
            .MethodReturnsForEachCase(
                "JegyHisztogram",
                [
                    MethodCase.Args(new[] { 5, 3, 5, 2 }).Returns(new[] { 0, 1, 1, 0, 2 }),
                    MethodCase.Args(Array.Empty<int>()).Returns(new[] { 0, 0, 0, 0, 0 }),
                    MethodCase.Args(new[] { 1, 1, 1 }).Returns(new[] { 3, 0, 0, 0, 0 }),
                    MethodCase.Args(new[] { 1, 2, 3, 4, 5 }).Returns(new[] { 1, 1, 1, 1, 1 }),
                    MethodCase.Args(new[] { 5, 5, 5, 5 }).Returns(new[] { 0, 0, 0, 0, 4 })
                ],
                12,
                "A JegyHisztogram helyes gyakorisagi tombot keszit.",
                Diagnostics(pilotMode, "array-methods.07.grade-histogram.behavior", ["array.counting", "histogram"], "Jegyhisztogram keszitese", 12),
                typeof(int[]))
            .Build();
    }

    private static TaskScore GradeLegnagyobbOsszeguSor(Assembly assembly, PilotMode pilotMode)
    {
        return ForTask(assembly, "array-methods.08.max-row-sum", "Legnagyobb osszegu sor", 12)
            .HasPublicStaticClass(0, "A Feladatok osztaly public static class.", Diagnostics(pilotMode, "array-methods.08.class.static", ["static-class"], "Feladatok public static class", 0))
            .HasPublicStaticMethod<int>(
                "LegnagyobbOsszeguSor",
                0,
                "Megvan a public static int LegnagyobbOsszeguSor(int[,] matrix) metodus.",
                Diagnostics(pilotMode, "array-methods.08.max-row-sum.signature", ["method.signature", "matrix"], "LegnagyobbOsszeguSor signature", 0),
                typeof(int[,]))
            .MethodReturnsForEachCase(
                "LegnagyobbOsszeguSor",
                [
                    MethodCase.Args(new int[,] { { 1, 2 }, { 5, 1 }, { 3, 3 } }).Returns(1),
                    MethodCase.Args(new int[,] { { 3, 3 }, { 2, 4 } }).Returns(0),
                    MethodCase.Args(new int[,] { { -5, -1 }, { -2, -2 } }).Returns(1),
                    MethodCase.Args(new int[,] { { 7, 8, 9 } }).Returns(0),
                    MethodCase.Args(new int[,] { { 1 }, { 5 }, { 3 } }).Returns(1)
                ],
                12,
                "A LegnagyobbOsszeguSor helyesen keresi a legnagyobb sorosszeget.",
                Diagnostics(pilotMode, "array-methods.08.max-row-sum.behavior", ["matrix", "maximum-search"], "Legnagyobb sorosszeg keresese", 12),
                typeof(int[,]))
            .Build();
    }

    private static TaskScore GradeLeghosszabbNovekvoSzakasz(Assembly assembly, PilotMode pilotMode)
    {
        return ForTask(assembly, "array-methods.09.longest-increasing-run", "Leghosszabb novekvo szakasz", 12)
            .HasPublicStaticClass(0, "A Feladatok osztaly public static class.", Diagnostics(pilotMode, "array-methods.09.class.static", ["static-class"], "Feladatok public static class", 0))
            .HasPublicStaticMethod<int>(
                "LeghosszabbNovekvoSzakasz",
                0,
                "Megvan a public static int LeghosszabbNovekvoSzakasz(int[] szamok) metodus.",
                Diagnostics(pilotMode, "array-methods.09.longest-increasing-run.signature", ["method.signature", "array"], "LeghosszabbNovekvoSzakasz signature", 0),
                typeof(int[]))
            .MethodReturnsForEachCase(
                "LeghosszabbNovekvoSzakasz",
                [
                    MethodCase.Args(new[] { 4, 6, 9, 3, 5, 7, 8, 2 }).Returns(4),
                    MethodCase.Args(new[] { 1 }).Returns(1),
                    MethodCase.Args(new[] { 1, 2, 3 }).Returns(3),
                    MethodCase.Args(new[] { 3, 2, 1 }).Returns(1),
                    MethodCase.Args(new[] { 1, 1, 1 }).Returns(1),
                    MethodCase.Args(new[] { 1, 2, 2, 3, 4 }).Returns(3)
                ],
                12,
                "A LeghosszabbNovekvoSzakasz helyesen meri a leghosszabb szigoru novekvo szakaszt.",
                Diagnostics(pilotMode, "array-methods.09.longest-increasing-run.behavior", ["array.traversal", "sequence"], "Leghosszabb novekvo szakasz", 12),
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


