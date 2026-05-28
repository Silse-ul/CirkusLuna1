using Cirkus_Luna.Pages.model;
using Cirkus_Luna.Pages.Model;

namespace LunaLibrary.Repository;

public class TicketRepository : ITicketRepository
{
  public List<Ticket> VIPTickets { get; set; }
  public int Price { get; set; }
  public int TicketType { get; set; }
  public List<Ticket> AllTickets { get; set; }

  public TicketRepository()
  {
    VIPTickets = new List<Ticket>();
    AllTickets = new List<Ticket>();
  }
  
  
  public void CalculatePrice()
  {
    Price = (int)TicketType;
  }
 

 




}