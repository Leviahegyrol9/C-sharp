using System.Reflection;
using TaskChecker.Grading;

Assembly examAssembly = typeof(global::CSharpGyakorloFeladatsor.Feladatok).Assembly;

PilotMode pilotMode = PilotMode.Basic110;
// PilotMode pilotMode = PilotMode.Diagnostics120;

IReadOnlyList<TaskScore> scores = Grader.Grade(examAssembly, pilotMode);

ScoreReporter.Write("Tombok es metodusok gyakorlo pontozo", scores);

await ResultSubmissionClient.TrySubmitAsync(scores, pilotMode);
