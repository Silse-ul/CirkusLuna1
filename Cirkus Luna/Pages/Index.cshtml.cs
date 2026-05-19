using Cirkus_Luna.Pages.model;
using Cirkus_Luna.Pages.Services;
using LunaLibrary.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cirkus_Luna.Pages;

public class IndexModel : PageModel
{
    public void OnGet()
    {
    }
    
    public List<Performance> Performances { get; set; }
   private readonly ILogger<IndexModel> _logger;
   public IndexModel(ILogger<IndexModel> logger, PerformanceService service)
    {
        _logger = logger;
        Performances = service.GetAll();
    }
    
    
}