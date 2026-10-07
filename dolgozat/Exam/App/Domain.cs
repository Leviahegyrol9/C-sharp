using System.Collections.Generic;

public record Student(string Name, double Average);
public record Product(string Name, string Category, int Price, int Stock);
public record Book(string Title, int BorrowCount);
public record ExamResult(string StudentName, int Points);
public record Player(string Name, int Matches, int Goals);
public record WarehouseItem(string Name, int UnitPrice, int Quantity);
public record ProjectTask(string Title, int EstimatedHours, bool Completed);
public record ProjectInfo(string Name, List<ProjectTask> Tasks);
