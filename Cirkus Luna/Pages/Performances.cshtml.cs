using Cirkus_Luna.Pages.model;
using Cirkus_Luna.Pages.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cirkus_Luna.Pages;

public class Performances : PageModel
{
    public void OnGet(string city, string date)
    {
        performances = _performanceService.Search(city, date);
    }
    

    public List<Performance> performances{get;set;}
    
    private readonly ILogger<Performances> _logger;
    private readonly PerformanceService _performanceService;

    public Performances(ILogger <Performances> logger, PerformanceService  performanceService)
    {
        _logger = logger;
        performances = performanceService.GetAll();
        _performanceService = performanceService;
    }
    
    
}