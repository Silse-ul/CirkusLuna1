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

    public void AddTicket(Ticket ticket)
    {
        if (ticket.Type == TicketType.VIP)
        {
            if (_ticketRepository.VIPTickets.Count < 11)
            {
                _ticketRepository.VIPTickets.Add(ticket);
                Console.WriteLine("VIP billet købt :)");
            
            }
            else
            {
                Console.WriteLine("Der er altså ik flere VIP pladser");
            }
                
        } 
        else
        {
            if (_ticketRepository.AllTickets.Count < 151)
            {
                _ticketRepository.AllTickets.Add(ticket);
                Console.WriteLine("Du har købt en almendelig billet");
            }
            else
            {
                Console.WriteLine("Der er ikke flere pladser i cikruset");
            }
            
        }
    }
   
    

}