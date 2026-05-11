using Cirkus_Luna.Pages.model;
using Cirkus_Luna.Pages.Shared;

namespace Cirkus_Luna.Pages.Services;

public class EmployeeService : IEmployeeService
{
    private IEmployeeRepository? _employeeRepository;

    public EmployeeService(ICostumerRepository costumerRepository)
    {
        IEmployeeRepository? employeeRepository = null;
        _employeeRepository = employeeRepository;
    }

    public List<Employee> GetAllEmployees()
    {
        return _employeeRepository.GetAll();
    }
}

    
