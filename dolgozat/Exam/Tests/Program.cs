using System.Reflection;
using TaskChecker.Grading;
using TaskChecker.Submitter.Abstraction;

Assembly examAssembly = typeof(SummaryTasks).Assembly;

GradingDetailMode detailMode = GradingDetailMode.Basic;

IReadOnlyList<TaskScore> scores = Grader.Grade(examAssembly, detailMode);

ScoreReporter.Write("LINQ ismetlo dolgozat pontozo", scores);

await ExamResultSubmitter.TrySubmitAsync(scores, detailMode);
