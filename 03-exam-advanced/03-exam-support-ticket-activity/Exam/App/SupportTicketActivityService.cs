using Microsoft.EntityFrameworkCore;

namespace LinqWhereCountEfAdvancedSupport;

public class SupportTicketActivityService
{
    private readonly AppDbContext _dbContext;

    public SupportTicketActivityService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    /// <summary>
    /// Számold meg a nyitott hibajegyeket.
    /// Egy hibajegy akkor nyitott, ha a Status mező értéke "Open".
    /// Használj CountAsync hívást kézi számláló változó nélkül.
    /// </summary>
    public async Task<int> CountOpenTicketsAsync()
    {
        await Task.CompletedTask;
        return 0;
    }

    /// <summary>
    /// Add vissza azokat az ügyfeleket, akiknek legalább minTicketCount hibajegyük van.
    /// A kapcsolt Tickets gyűjtemény darabszámát Count művelettel vizsgáld.
    /// Használj Where szűrést és ToListAsync materializálást.
    /// </summary>
    public async Task<List<Customer>> GetCustomersWithAtLeastTicketsAsync(int minTicketCount)
    {
        await Task.CompletedTask;
        return [];
    }

    /// <summary>
    /// Add vissza azokat a hibajegyeket, amelyekhez legalább minMessageCount üzenet tartozik.
    /// A kapcsolt Messages gyűjtemény darabszámát Count művelettel vizsgáld.
    /// Használj Where szűrést és ToListAsync materializálást.
    /// </summary>
    public async Task<List<Ticket>> GetTicketsWithAtLeastMessagesAsync(int minMessageCount)
    {
        await Task.CompletedTask;
        return [];
    }

    /// <summary>
    /// Számold meg a megadott státuszú hibajegyeket.
    /// A status paramétert a Ticket.Status mezővel hasonlítsd össze.
    /// Használj CountAsync hívást kézi számláló változó nélkül.
    /// </summary>
    public async Task<int> CountTicketsByStatusAsync(string status)
    {
        await Task.CompletedTask;
        return 0;
    }

    /// <summary>
    /// Add vissza a customerId paraméterrel megadott ügyfél hibajegyeit.
    /// A szűrést a Ticket.CustomerId mező alapján végezd.
    /// Használj Where szűrést és ToListAsync materializálást.
    /// </summary>
    public async Task<List<Ticket>> GetTicketsForCustomerAsync(int customerId)
    {
        await Task.CompletedTask;
        return [];
    }
}