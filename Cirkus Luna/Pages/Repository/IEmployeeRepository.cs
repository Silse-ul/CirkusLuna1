using Cirkus_Luna.Pages.model;

namespace Cirkus_Luna.Pages.Shared;

public interface IEmployeeRepository
{
    public List<Employee> GetAll();

    public Employee GetById(int id);
}