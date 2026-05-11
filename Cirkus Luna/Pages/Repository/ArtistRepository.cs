using Cirkus_Luna.Pages.model;

namespace Cirkus_Luna.Pages;

public class ArtistRepository : IArtistRepository
{
    
    private List<Artist> _artistsList;

    public ArtistRepository()
    {
        //tom liste 
        _artistsList = new List<Artist>();
        // vi tilføjer lokaler her 
        Artist h = new Artist();
        _artistsList.Add(h);
        Artist t = new Artist();
        _artistsList.Add(t);
        Artist f = new Artist();
        _artistsList.Add(f);
        Artist d = new Artist();
        _artistsList.Add(d);

    }

    public List<Artist> GetAll()
    {
        return _artistsList;
        
    }


    public Artist GetById(int id)
    {
        foreach (Artist item in _artistsList )
        {
            if (item.Id == id)
            {
                return item;
            }
        }
        return null;
    }
}