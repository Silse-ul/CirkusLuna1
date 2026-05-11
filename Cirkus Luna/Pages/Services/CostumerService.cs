using Cirkus_Luna.Pages.model;

namespace Cirkus_Luna.Pages.Services;

public class CostumerService : ICostumerService
{
    private ICostumerRepository _costumerRepository;

    public CostumerService(ICostumerRepository costumerRepository)
    {
        _costumerRepository = costumerRepository;
    }
    public List<Costumer> GetAllArtists()
    {
        var allCostumer = _costumerRepository.GetAll();
        return allCostumer;
    }
}