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
    public List<Artist> Artists { get; set; }
   private readonly ILogger<IndexModel> _logger;
   private readonly PerformanceService _performanceService;
   private readonly ArtistService _artistService;

   public IndexModel(ILogger<IndexModel> logger, PerformanceService performanceService, ArtistService artistService)
   
    {
        _logger = logger;
        _performanceService = performanceService;
        _artistService = artistService;
        Performances = _performanceService.GetAll();
        Artists = _artistService.GetAllArtists();
    }
   
    
   
   
    
    
}