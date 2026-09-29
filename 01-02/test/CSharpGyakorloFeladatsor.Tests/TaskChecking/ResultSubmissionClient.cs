using System.Text.Json;
using System.Text.Json.Serialization;
using TaskChecker.Grading;
using TaskChecker.Submitter.Abstraction;
using TaskChecker.Submitter.Application;
using TaskChecker.Submitter.Domain;
using TaskChecker.Submitter.Grading;
using TaskChecker.Submitter.Infrastructure;

internal static class ResultSubmissionClient
{
    private const string AssignmentSettingsFileName = ".feladatbeallitas.json";
    private const string StudentSettingsDirectoryName = "TaskChecker";
    private const string StudentSettingsFileName = "adataim.json";
    private const string SubmissionPreviewFileName = "submission-preview.json";
    private const string ApiBaseUrlEnvironmentVariableName = "TASKCHECKER_API_BASE_URL";

    private static readonly JsonSerializerOptions PreviewJsonSerializerOptions = new(JsonSerializerDefaults.Web)
    {
        WriteIndented = true,
        Converters = { new JsonStringEnumConverter() }
    };

    public static async Task TrySubmitAsync(IReadOnlyList<TaskScore> scores, PilotMode pilotMode)
    {
        try
        {
            TaskCheckerClientSettings settings = LoadSettings();

            IReadOnlyList<TestTaskResult> results = TestTaskResultMapper.FromMany(scores);
            TestResultSubmissionBuilder builder = TestResultSubmitter
                .CreateSubmission()
                .WithSchemaVersion(settings.Assignment.SchemaVersion)
                .WithEducationId(settings.Student.StudentId)
                .WithStudentDetails(settings.Student.StudentName, settings.Student.ClassName)
                .WithAssignment(settings.Assignment.AssignmentId)
                .WithAssignmentVersion(settings.Assignment.AssignmentVersion)
                .WithSecurityMode(settings.Assignment.SubmissionMode)
                .WithTestPackage(CreateTestPackageIdentity())
                .WithAuditInfo(CreateAuditInfo())
                .AddResults(results);

            if (pilotMode == PilotMode.Diagnostics120)
            {
                SubmissionDiagnostics diagnostics = TestTaskResultMapper.ToDiagnostics(scores);
                builder.WithDiagnostics(diagnostics);
            }

            TestResultSubmission submission = builder.Build();
            WriteSubmissionPreview(submission);

            using HttpClient httpClient = new();
            TaskCheckerSubmitterOptions options = new()
            {
                BaseUrl = GetApiBaseUrl(settings.Assignment),
                Timeout = TimeSpan.FromSeconds(5)
            };

            ITestResultSender sender = new HttpTestResultSender(httpClient, options);

            await TestResultSubmitter.SubmitAsync(sender, submission);
            global::System.Console.WriteLine("Eredmeny bekuldve a TaskChecker rendszerbe.");
        }
        catch (Exception exception) when (IsSettingsException(exception))
        {
            global::System.Console.WriteLine($"TaskChecker beallitasi hiba: {exception.Message}");
            return;
        }
        catch (HttpRequestException exception)
        {
            global::System.Console.WriteLine($"TaskChecker API nem elerheto: {exception.Message}");
        }
        catch (TaskCanceledException exception)
        {
            global::System.Console.WriteLine($"TaskChecker API timeout: {exception.Message}");
        }
    }

    private static TaskCheckerClientSettings LoadSettings()
    {
        string projectDirectory = FindProjectDirectory();
        string assignmentSettingsPath = Path.Combine(projectDirectory, AssignmentSettingsFileName);

        if (!File.Exists(assignmentSettingsPath))
            throw new FileNotFoundException($"Nem talalhato {AssignmentSettingsFileName} fajl.");

        TaskCheckerAssignmentSettings assignmentSettings = ReadJson<TaskCheckerAssignmentSettings>(assignmentSettingsPath);
        ValidateAssignmentSettings(assignmentSettings);

        TaskCheckerStudentSettings studentSettings = LoadOrCreateStudentSettings(projectDirectory);
        ValidateStudentSettings(studentSettings);

        return new TaskCheckerClientSettings(assignmentSettings, studentSettings);
    }

    private static TaskCheckerStudentSettings LoadOrCreateStudentSettings(string projectDirectory)
    {
        string studentSettingsPath = GetStudentSettingsPath(projectDirectory);

        if (File.Exists(studentSettingsPath))
            return ReadJson<TaskCheckerStudentSettings>(studentSettingsPath);

        TaskCheckerStudentSettings settings = AskStudentSettings();
        Directory.CreateDirectory(Path.GetDirectoryName(studentSettingsPath)!);

        string json = JsonSerializer.Serialize(settings, PreviewJsonSerializerOptions);
        File.WriteAllText(studentSettingsPath, json);

        global::System.Console.WriteLine();
        global::System.Console.WriteLine($"Diakadatok mentve: {studentSettingsPath}");

        return settings;
    }

    private static TaskCheckerStudentSettings AskStudentSettings()
    {
        while (true)
        {
            global::System.Console.WriteLine();
            global::System.Console.WriteLine("TaskChecker diakadatok beallitasa");
            global::System.Console.WriteLine();

            string studentId = AskRequired("Add meg az egyedi azonositodat:");
            string studentName = AskRequired("Add meg a neved:");
            string className = AskRequired("Add meg az osztalyod:");

            global::System.Console.WriteLine();
            global::System.Console.WriteLine("Ezekkel az adatokkal kuldjuk be az eredmenyt:");
            global::System.Console.WriteLine($"Azonosito: {studentId}");
            global::System.Console.WriteLine($"Nev: {studentName}");
            global::System.Console.WriteLine($"Osztaly: {className}");
            global::System.Console.WriteLine();
            global::System.Console.Write("Rendben? (i/n): ");

            string? answer = global::System.Console.ReadLine();
            if (string.Equals(answer?.Trim(), "i", StringComparison.OrdinalIgnoreCase))
            {
                return new TaskCheckerStudentSettings
                {
                    StudentId = studentId,
                    StudentName = studentName,
                    ClassName = className
                };
            }
        }
    }

    private static string AskRequired(string prompt)
    {
        while (true)
        {
            global::System.Console.Write($"{prompt} ");
            string? value = global::System.Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(value))
                return value.Trim();

            global::System.Console.WriteLine("Ez az adat kotelezo.");
        }
    }

    private static T ReadJson<T>(string path)
    {
        string json = File.ReadAllText(path);
        T? settings = JsonSerializer.Deserialize<T>(json, PreviewJsonSerializerOptions);

        return settings ?? throw new InvalidOperationException($"A TaskChecker beallitasi fajl nem olvashato: {path}");
    }

    private static void ValidateStudentSettings(TaskCheckerStudentSettings settings)
    {
        if (string.IsNullOrWhiteSpace(settings.StudentId))
            throw new InvalidOperationException("A studentId megadasa kotelezo.");

        if (string.IsNullOrWhiteSpace(settings.StudentName))
            throw new InvalidOperationException("A studentName megadasa kotelezo.");

        if (string.IsNullOrWhiteSpace(settings.ClassName))
            throw new InvalidOperationException("A className megadasa kotelezo.");
    }

    private static void ValidateAssignmentSettings(TaskCheckerAssignmentSettings settings)
    {
        if (string.IsNullOrWhiteSpace(settings.SchemaVersion))
            throw new InvalidOperationException("A schemaVersion megadasa kotelezo.");

        if (string.IsNullOrWhiteSpace(settings.AssignmentId))
            throw new InvalidOperationException("Az assignmentId megadasa kotelezo.");

        if (string.IsNullOrWhiteSpace(settings.AssignmentVersion))
            throw new InvalidOperationException("Az assignmentVersion megadasa kotelezo.");
    }

    private static void WriteSubmissionPreview(TestResultSubmission submission)
    {
        var request = TestResultSubmissionRequestMapper.ToRequestDto(submission);
        string previewPath = GetSubmissionPreviewPath();
        string json = JsonSerializer.Serialize(request, PreviewJsonSerializerOptions);

        try
        {
            File.WriteAllText(previewPath, json);
            global::System.Console.WriteLine($"Bekuldesi JSON preview: {previewPath}");
        }
        catch (Exception exception) when (exception is IOException or UnauthorizedAccessException)
        {
            global::System.Console.WriteLine($"Bekuldesi JSON preview nem irhato: {exception.Message}");
        }
    }

    private static string GetSubmissionPreviewPath()
    {
        string? configuredPath = Environment.GetEnvironmentVariable("TASKCHECKER_SUBMISSION_PREVIEW_PATH");

        return string.IsNullOrWhiteSpace(configuredPath)
            ? Path.Combine(Environment.CurrentDirectory, SubmissionPreviewFileName)
            : configuredPath;
    }

    private static bool IsSettingsException(Exception exception)
    {
        return exception is FileNotFoundException ||
            exception is JsonException ||
            exception is InvalidOperationException ||
            exception is UriFormatException ||
            exception is IOException ||
            exception is UnauthorizedAccessException;
    }

    private static Uri GetApiBaseUrl(TaskCheckerAssignmentSettings settings)
    {
        string? apiBaseUrl = Environment.GetEnvironmentVariable(ApiBaseUrlEnvironmentVariableName);

        return string.IsNullOrWhiteSpace(apiBaseUrl)
            ? settings.ApiBaseUrl
            : new Uri(apiBaseUrl);
    }

    private static string FindProjectDirectory()
    {
        DirectoryInfo? directory = new(AppContext.BaseDirectory);
        string? assignmentSettingsDirectory = null;

        while (directory is not null)
        {
            if (directory.GetFiles("*.csproj").Length > 0)
                return directory.FullName;

            string assignmentSettingsPath = Path.Combine(directory.FullName, AssignmentSettingsFileName);
            if (File.Exists(assignmentSettingsPath))
                assignmentSettingsDirectory ??= directory.FullName;

            directory = directory.Parent;
        }

        if (assignmentSettingsDirectory is not null)
            return assignmentSettingsDirectory;

        throw new FileNotFoundException("Nem talalhato a tesztprojekt mappaja.");
    }

    private static string GetStudentSettingsPath(string projectDirectory)
    {
        return Path.Combine(projectDirectory, StudentSettingsDirectoryName, StudentSettingsFileName);
    }

    private static TestPackageIdentity CreateTestPackageIdentity()
    {
        string assemblyPath = typeof(Program).Assembly.Location;
        FileInfo assemblyFile = new(assemblyPath);

        return new TestPackageIdentity
        {
            TestPackageId = typeof(Program).Assembly.GetName().Name,
            ByteSize = assemblyFile.Exists ? assemblyFile.Length : 0,
            Sha256 = null
        };
    }

    private static SubmissionAuditInfo CreateAuditInfo()
    {
        return new SubmissionAuditInfo
        {
            MachineName = Environment.MachineName,
            OperatingSystemUserName = Environment.UserName,
            SubmitterVersion = typeof(TestResultSubmitter).Assembly.GetName().Version?.ToString()
        };
    }

    private sealed record TaskCheckerClientSettings(
        TaskCheckerAssignmentSettings Assignment,
        TaskCheckerStudentSettings Student);

    private sealed record TaskCheckerAssignmentSettings
    {
        public string SchemaVersion { get; init; } = "1.1.0";

        public required string AssignmentId { get; init; }

        public string AssignmentVersion { get; init; } = "1.0.0";

        public SubmissionSecurityMode SubmissionMode { get; init; } = SubmissionSecurityMode.Basic;

        public required Uri ApiBaseUrl { get; init; }
    }

    private sealed record TaskCheckerStudentSettings
    {
        public required string StudentId { get; init; }

        public required string StudentName { get; init; }

        public required string ClassName { get; init; }
    }
}
