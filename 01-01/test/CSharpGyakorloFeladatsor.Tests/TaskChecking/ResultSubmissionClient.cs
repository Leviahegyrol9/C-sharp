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
    private const string LocalSettingsFileName = ".taskchecker.json";
    private const string ExampleSettingsFileName = ".taskchecker.example.json";
    private const string LocalOverrideSettingsFileName = ".taskchecker.local.json";
    private const string SubmissionPreviewFileName = "submission-preview.json";
    private const string ApiBaseUrlEnvironmentVariableName = "TASKCHECKER_API_BASE_URL";

    private static readonly JsonSerializerOptions PreviewJsonSerializerOptions = new(JsonSerializerDefaults.Web)
    {
        WriteIndented = true,
        Converters = { new JsonStringEnumConverter() }
    };

    public static async Task TrySubmitAsync(IReadOnlyList<TaskScore> scores, PilotMode pilotMode)
    {
        TaskCheckerExamSettings settings;

        try
        {
            settings = TaskCheckerExamSettingsReader.LoadFromCurrentDirectory();
        }
        catch (Exception exception) when (IsSettingsException(exception))
        {
            global::System.Console.WriteLine($"TaskChecker beallitasi hiba: {exception.Message}");
            return;
        }

        IReadOnlyList<TestTaskResult> results = TestTaskResultMapper.FromMany(scores);
        TestResultSubmissionBuilder builder = TestResultSubmitter
            .CreateSubmission()
            .WithSchemaVersion(settings.SchemaVersion)
            .WithEducationId(settings.EducationId)
            .WithStudentDetails(settings.StudentName, settings.ClassName)
            .WithAssignment(settings.AssignmentId)
            .WithAssignmentVersion(settings.AssignmentVersion)
            .WithSecurityMode(settings.SubmissionMode)
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

        try
        {
            using HttpClient httpClient = new();
            TaskCheckerSubmitterOptions options = new()
            {
                BaseUrl = GetApiBaseUrl(settings),
                Timeout = TimeSpan.FromSeconds(5)
            };

            ITestResultSender sender = new HttpTestResultSender(httpClient, options);

            await TestResultSubmitter.SubmitAsync(sender, submission);
            global::System.Console.WriteLine("Eredmeny bekuldve a TaskChecker rendszerbe.");
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
            exception is UriFormatException;
    }

    private static Uri GetApiBaseUrl(TaskCheckerExamSettings settings)
    {
        string? apiBaseUrl = Environment.GetEnvironmentVariable(ApiBaseUrlEnvironmentVariableName);

        return string.IsNullOrWhiteSpace(apiBaseUrl)
            ? TryReadLocalApiBaseUrl() ?? settings.ApiBaseUrl
            : new Uri(apiBaseUrl);
    }

    private static Uri? TryReadLocalApiBaseUrl()
    {
        string? localSettingsPath = FindSettingsFile(LocalOverrideSettingsFileName);
        if (localSettingsPath is null)
            return null;

        string json = File.ReadAllText(localSettingsPath);
        TaskCheckerLocalSettings? settings = JsonSerializer.Deserialize<TaskCheckerLocalSettings>(
            json,
            PreviewJsonSerializerOptions);

        return settings?.ApiBaseUrl;
    }

    private static string? FindSettingsFile(string fileName)
    {
        DirectoryInfo? directory = new(AppContext.BaseDirectory);

        while (directory is not null)
        {
            string path = Path.Combine(directory.FullName, fileName);
            if (File.Exists(path))
                return path;

            directory = directory.Parent;
        }

        return null;
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

    private sealed record TaskCheckerLocalSettings
    {
        public Uri? ApiBaseUrl { get; init; }
    }
}
