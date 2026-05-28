using Cirkus_Luna.Pages.model;
using Cirkus_Luna.Pages.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cirkus_Luna.Pages;

public class artistDetails : PageModel
{
    public void OnGet()
    {
        
    }
    
    public List<Artist> Artists { get; set; }
    private readonly ArtistService _artistService;
    public artistDetails(ArtistService art )
   
    {
        _artistService = art;
        Artists = _artistService.GetAllArtists();
    }

    
}