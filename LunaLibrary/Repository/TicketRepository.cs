using Cirkus_Luna.Pages.model;

namespace LunaLibrary.Repository;

public class TicketRepository : ITicketRepository
{
  public List<Ticket> VIPTickets { get; set; }
  public List<Ticket> AllTickets { get; set; }

  public TicketRepository()
  {
    VIPTickets = new List<Ticket>();
    AllTickets = new List<Ticket>();
  }
  
   
   


}