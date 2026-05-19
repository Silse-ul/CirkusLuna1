using Cirkus_Luna.Pages.model;
using LunaLibrary.Repository;

namespace Cirkus_Luna.Pages.Services;

public class TicketService
{
    private readonly ITicketRepository _ticketRepository;
    public TicketService(ITicketRepository repo)
    {
        _ticketRepository = repo;
    }
    
    
    if (Ticket.Type == TicketType.VIP)
    {
        if (repo.VIPTicket.count < 11)
        {
            
        }
    }
    

}