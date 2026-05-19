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

    public void CreatePerformance(Performance performance)
    {
        if(performance performance.Date < DateTime.Now) //For guds skyld ret den Trine, så den er mellem de datoer der står i opg.
        {
            throw new Exception("Vi har ingen shows i den valgte periode");
        }
            
        //Send ordren om at gemme til repo der bruger Add()
        _performanceRepository.Add(performance);
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