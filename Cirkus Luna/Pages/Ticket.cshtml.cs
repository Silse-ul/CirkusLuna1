using Cirkus_Luna.Pages.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cirkus_Luna.Pages;

public class Ticket : PageModel
{

    [BindProperty]
    public TicketType TicketType { get; set; }
    public int PerformanceId { get; set; }

    public string CustomerName { get; set; }
   
    public Ticket Tickets { get; set; }

    public void OnGet(int id )
    {
        PerformanceId = id; 
    }

   
}