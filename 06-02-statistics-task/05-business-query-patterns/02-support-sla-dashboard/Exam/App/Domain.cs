public class SupportTicket
{
    public int Id { get; set; }
    public string AssignedAgent { get; set; } = string.Empty;
    public bool IsClosed { get; set; }
    public bool ClosedWithinSla { get; set; }
    public int FirstResponseMinutes { get; set; }
}

public class SupportSlaDashboardDto
{
    public int TotalTicketCount { get; set; }
    public int ClosedTicketCount { get; set; }
    public double ClosedWithinSlaPercentage { get; set; }
    public double AverageFirstResponseMinutes { get; set; }
    public int OverloadedAgentCount { get; set; }
}
