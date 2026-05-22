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
    public List<Performance> Search(string criteria)
    {
        throw new NotImplementedException();
    }
    public List <Performance> Search(string city, string date )
    {
        List<Performance> searchList = new List<Performance>();

        foreach (Performance performance in _performanceList)
        {
            if ((performance.City.ToLower() == city.ToLower()) || (performance.Date.ToLower() == date.ToLower()))
            {
                searchList.Add(performance);
            }
           
        }

        return searchList;
        
    }
}