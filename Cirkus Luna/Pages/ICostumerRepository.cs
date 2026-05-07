namespace Cirkus_Luna.Pages;

public interface ICostumerRepository
{
    public List<Costumer> GetAll();

    public Costumer GetById(int id);

}