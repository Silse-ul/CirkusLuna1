using Cirkus_Luna.Pages.model;
using LunaLibrary.Repository;

namespace Cirkus_Luna.Pages.Services;

public class PerformanceService
{
    private readonly IPerformanceRepository _performanceRepository;
    public PerformanceService(IPerformanceRepository repo)
    {
        _performanceRepository = repo;
    }

    public void AddArtist(int performanceId, Artist artist)
    {
        Performance performance = _performanceRepository.GetById(performanceId);
        
        if (performance != null)
        {
            bool alreadyExists = false;

            foreach (Artist existingArtist in performance.Artists)
            {
                if (existingArtist.Id == artist.Id)
                {
                    alreadyExists = true;
                    break;
                }
            }
            if (!alreadyExists)
            {
                _performanceRepository.AddArtist(performanceId, artist);
                artist.Performances.Add(performance);
            }
        }
    }
    
    //Videresender forespørgsel
    public List<Performance> GetAll()
    {
        return _performanceRepository.GetAll();
    }
    public Performance GetPerformance(int id)
    {
        return _performanceRepository.GetById(id);
    }
    public List<Performance> Search(string search)
    {
        return _performanceRepository.Search(search);
    }
     
   
}