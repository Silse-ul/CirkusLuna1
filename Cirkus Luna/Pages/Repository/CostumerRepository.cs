using Cirkus_Luna.Pages.model;

namespace Cirkus_Luna.Pages;

public class CostumerRepository : ICostumerRepository
{
    private List<Costumer> _costumersList;

    public CostumerRepository()
    {
        //tom liste 
        _costumersList = new List<Costumer>();
        // vi tilføjer lokaler her 
        Costumer s = new Costumer();
        _costumersList.Add(s);
        Costumer u = new Costumer();
        _costumersList.Add(u);
        Costumer k = new Costumer();
        _costumersList.Add(k);
        Costumer l = new Costumer();
        _costumersList.Add(l);

    }

    public List<Costumer> GetAll()
    {
        return _costumersList;
        
    }


    public Costumer GetById(int id)
    {
        foreach (Costumer item in _costumersList )
        {
            if (item.Id == id)
            {
                return item;
            }
        }
        return null;
    }
}

