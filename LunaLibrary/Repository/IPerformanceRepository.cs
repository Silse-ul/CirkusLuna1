using Cirkus_Luna.Pages.model;

namespace LunaLibrary.Repository;

public interface IPerformanceRepository
{
    public List<Performance> GetAll()
    {
        throw new NotImplementedException();
    }

    public Performance GetById(int id)
    {
        throw new NotImplementedException();
    }

    public  void Add (Performance performance)
    {
        throw new NotImplementedException();
    }

    public void AddArtist(int performanceId, Artist artist);

    public void Update(Performance performance)
    {
        throw new NotImplementedException();
    }

    public void Delete(Performance performance)
    {
        throw new NotImplementedException();
    }

    public List<Performance> Search(string search);
}
