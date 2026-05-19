using Cirkus_Luna.Pages.model;

namespace LunaLibrary.Repository;

public interface ITicketRepository 
{ 
    List<Ticket> AllTickets { get; set; }
    List<Ticket> VIPTickets { get; set; }
}