using System.Collections.Generic;

public static class SampleData
{
    public static List<Student> GetStudents() =>
    [
        new("Anna", 4.6), new("Bela", 3.8), new("Csilla", 4.0), new("David", 2.9)
    ];

    public static List<Product> GetProducts() =>
    [
        new("Keyboard", "IT", 12000, 8), new("Mouse", "IT", 6000, 0),
        new("Monitor", "IT", 65000, 4), new("Chair", "Office", 48000, 5),
        new("Desk", "Office", 55000, 2)
    ];

    public static List<Book> GetBooks() =>
    [
        new("Dune", 24), new("Solaris", 9), new("1984", 31), new("Foundation", 15)
    ];

    public static List<ExamResult> GetExamResults() =>
    [
        new("Anna", 82), new("Bela", 45), new("Csilla", 70), new("David", 50)
    ];

    public static List<Player> GetPlayers() =>
    [
        new("Adam", 8, 5), new("Bence", 4, 9), new("Csaba", 10, 7), new("Daniel", 6, 3)
    ];

    public static List<WarehouseItem> GetWarehouseItems() =>
    [
        new("Cable", 1200, 10), new("Adapter", 3500, 4), new("Monitor", 65000, 6), new("Pen", 300, 100)
    ];

    public static List<ProjectInfo> GetProjects() =>
    [
        new("Website", [new("Design", 8, true), new("Frontend", 12, false), new("Backend", 16, false)]),
        new("MobileApp", [new("UI", 6, true), new("API", 8, true), new("Testing", 5, true)]),
        new("Warehouse", [new("Database", 10, true), new("API", 15, false), new("Reports", 8, false), new("Deploy", 4, false)])
    ];
}
