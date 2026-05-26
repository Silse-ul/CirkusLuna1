using Cirkus_Luna.Pages.model;
using Cirkus_Luna.Pages.Model;

namespace LunaLibrary.Repository;

public interface ITicketRepository 
{ 
    List<Ticket> AllTickets { get; set; }
    List<Ticket> VIPTickets { get; set; }
    int Price { get; set; }
    int TicketType { get; set; }
    
    public void CalculatePrice()
    {
        Price = (int)TicketType;
    }



    
}