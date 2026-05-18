namespace LunaLibrary.Repository;

public abstract class IPerformanceRepository
{
    public List<Performance> GetAll()
    {
        throw new NotImplementedException();
    }

    public Performance GetById(int id)
    {
        throw new NotImplementedException();
    }

    public  void Add(Performance performance)
    {
        throw new NotImplementedException();
    }

    public void Update(Performance performance)
    {
        throw new NotImplementedException();
    }

    public void Delete(Performance performance)
    {
        throw new NotImplementedException();
    }
}

public class Performance
{
    public DateTime Date { get; set; }
    public int Id { get; set; }
}