namespace LinqWhereCountEfAdvancedLibrary;

public class Reader
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<BorrowRecord> BorrowRecords { get; set; } = [];
}

public class BorrowRecord
{
    public int Id { get; set; }
    public int ReaderId { get; set; }
    public string BookTitle { get; set; } = string.Empty;
    public bool IsOverdue { get; set; }
    public Reader? Reader { get; set; }
}