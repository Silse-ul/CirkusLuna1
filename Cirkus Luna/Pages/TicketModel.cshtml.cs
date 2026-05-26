using Cirkus_Luna.Pages.model;
using Cirkus_Luna.Pages.Model;
using Cirkus_Luna.Pages.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cirkus_Luna.Pages;

public class TicketModel : PageModel
{
private readonly TicketService _ticketService;
public TicketModel(TicketService ticketService)
{
    _ticketService = ticketService;
}

[BindProperty]
public string CustomerName { get; set; }


    [BindProperty]
    public TicketType TicketType { get; set; }
    public int PerformanceId { get; set; }
    public TicketType Type { get; set; }

    public void CalculatePrice()
    {
        Price = (int)TicketType;
    }
    public int Price { get; set; }

    
   
    public Ticket Tickets { get; set; }

    public void OnGet()
    {
       
    }

    

    public void OnPost()
    {
        Ticket ticket = new Ticket();
        _ticketService.AddTicket(ticket);
        ticket.CalculatePrice();

        ticket.CustomerName = CustomerName;
        ticket.Type = TicketType;
        
        Price = ticket.Price;

        
    }

    
}

