using Cirkus_Luna.Pages.model;
using Cirkus_Luna.Pages.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cirkus_Luna.Pages;

public class Performances : PageModel
{
    public void OnGet(string city, string date)
    {
        Performances1 = _performanceService.Search(city, date);
    }
    

    public List<Performance> Performances1{get;set;}
    
    private readonly ILogger<Performances> _logger;
    private readonly PerformanceService _performanceService;

    public Performances(ILogger <Performances> logger, PerformanceService  performanceService)
    {
        _logger = logger;
        Performances1 = performanceService.GetAll();
        _performanceService = performanceService;
    }
    
    
}