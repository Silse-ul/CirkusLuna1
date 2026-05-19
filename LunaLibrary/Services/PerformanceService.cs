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

    

    //Videresender forespørgsel
    public List<Performance> GetAll()
    {
        return _performanceRepository.GetAll();
    }
    public Performance GetPerformance(int id)
    {
        return _performanceRepository.GetById(id);
    }
}