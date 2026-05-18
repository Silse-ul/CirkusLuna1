using Cirkus_Luna.Pages.model;

namespace Cirkus_Luna.Pages.Services;

public class ArtistService : IArtistService
{
    
    private IArtistRepository _artistRepository;

    public ArtistService(IArtistRepository artistRepository)
    {
        _artistRepository = artistRepository;
    }
    public List<Artist> GetAllArtists()
    {
        return _artistRepository.GetAll();
    }

    

    
    
}