using Cirkus_Luna.Pages.Shared;

namespace Cirkus_Luna.Pages;

public class WorkerRepository : IWorkerRepository
{
    private List<Worker> _workersList;

    public WorkerRepository()
    {
        //tom liste 
        _workersList = new List<Worker>();
        // vi tilføjer lokaler her 
        Worker m = new Worker();
        _workersList.Add(m);
        Worker a = new Worker();
        _workersList.Add(a);
        Worker g = new Worker();
        _workersList.Add(g);
        Worker p = new Worker();
        _workersList.Add(p);

    }

    public List<Worker> GetAll()
    {
        return _workersList;
        
    }


    public Worker GetById(int id)
    {
        foreach (Worker item in _workersList )
        {
            if (item.Id == id)
            {
                return item;
            }
        }
        return null;
    }
}