using TaskChecker.Grading;

internal static class ScoreReporter
{
    public static void Write(string title, IReadOnlyList<TaskScore> scores)
    {
        decimal total = scores.Sum(score => score.Points);
        decimal maxTotal = scores.Sum(score => score.MaxPoints);

        global::System.Console.WriteLine(title);
        global::System.Console.WriteLine();

        for (int i = 0; i < scores.Count; i++)
        {
            TaskScore score = scores[i];
            global::System.Console.WriteLine($"{i + 1}. feladat - {score.Name}: {score.Points}/{score.MaxPoints} pont");

            foreach (string message in score.Messages)
                global::System.Console.WriteLine($"  - {message}");

            global::System.Console.WriteLine();
        }

        global::System.Console.WriteLine($"Osszesen: {total}/{maxTotal} pont");
    }
}
