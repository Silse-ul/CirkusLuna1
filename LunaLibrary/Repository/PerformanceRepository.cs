using Cirkus_Luna.Pages.model;

namespace LunaLibrary.Repository;



public class PerformanceRepository : IPerformanceRepository
{
    private List<Performance> _performanceList;

    public PerformanceRepository()
    { 
        //Tom liste der gemmer de ansatte
        _performanceList = new List<Performance>();

        //Vi smider nogle i fra start
        Performance Odense = new Performance("03-05-2026", "Odense", "Ørbækvej 350", "19.00" ); 
        _performanceList.Add(Odense);
        Performance Aalborg = new Performance("11-05-2026", "Aalborg", "Skydebanevej 12", "18:30");
        _performanceList.Add(Aalborg);
        Performance Esbjerg = new Performance("24-05-2026", "Esbjerg", "Gammel Vardevej 82", "20:00"); 
        _performanceList.Add(Esbjerg);
        Performance Randers = new Performance("02-06-2026", "Randers", "Viborgvej 45", "17:30" ); 
        _performanceList.Add(Randers);
        Performance Roskilde = new Performance("14-06-2026", "Roskilde", "Darupvej 19", "19:30");
        _performanceList.Add(Roskilde);
        Performance Herning = new Performance("28-06-2026", "Herning", "Messevejen 6", "20:30" ); 
        _performanceList.Add(Herning);
        Performance Kolding = new Performance("09-07-2026", "Kolding", "Armbloden 2", "18:00" ); 
        _performanceList.Add(Kolding);
        Performance Naestved = new Performance("21-07-2026", "Næstved", "Ringerstedgade 120", "19.00" ); 
        _performanceList.Add(Naestved);
        Performance Vejle = new Performance("08-08-2026", "Vejle", "Havnepladsen 14", "20:00" ); 
        _performanceList.Add(Vejle);
        Performance Hjorring = new Performance("27-08-2026", "Hjørring", "Stadionvej 5", "18:30" ); 
        _performanceList.Add(Hjorring);
     


    }

    public List<Performance> GetAll()
    {
        return _performanceList;
    }

     
    public void Delete(Performance performance)
    {
        throw new NotImplementedException();
    }

    public void Add(Performance performance)
    {
        int Id = _performanceList.Count + 1;
        //bookingsystem.RoomId = nextId; skal vores PId matche noget?
        _performanceList.Add(performance);
    }

    public void Update(Performance performance)
    {
        throw new NotImplementedException();
    }
}
    

