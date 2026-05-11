using Cirkus_Luna.Pages.model;

namespace Cirkus_Luna.Pages;

public interface IArtistRepository
{
    public List<Artist> GetAll();

    public Artist GetById(int id);
}