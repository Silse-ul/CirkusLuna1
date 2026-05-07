namespace Cirkus_Luna.Pages.Shared;

public interface IWorkerRepository
{
    public List<Worker> GetAll();

    public Worker GetById(int id);
}