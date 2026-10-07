using System;

Console.WriteLine("LINQ ismetlo dolgozat - 45 perc");
Console.WriteLine("1. " + string.Join(", ", SummaryTasks.GetGoodStudentNames(SampleData.GetStudents())));
Console.WriteLine("2. " + SummaryTasks.CountProductsInStock(SampleData.GetProducts()));
Console.WriteLine("3. " + string.Join(", ", SummaryTasks.GetPopularBookTitles(SampleData.GetBooks())));
Console.WriteLine("4. " + SummaryTasks.GetSuccessfulExamAverage(SampleData.GetExamResults()));
Console.WriteLine("5. " + string.Join(", ", SummaryTasks.GetAffordableProductNames(SampleData.GetProducts(), "IT")));
Console.WriteLine("6. " + SummaryTasks.GetBestScorerName(SampleData.GetPlayers()));
Console.WriteLine("7. " + SummaryTasks.GetValuableStockTotal(SampleData.GetWarehouseItems()));
Console.WriteLine("8. " + string.Join(", ", SummaryTasks.GetImportantProjectNames(SampleData.GetProjects())));
