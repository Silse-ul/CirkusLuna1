using Cirkus_Luna.Pages.model;
using Cirkus_Luna.Pages.Shared;

namespace Cirkus_Luna.Pages;

public class EmployeeRepository : IEmployeeRepository
{
    private List<Employee> _employeessList;

    public EmployeeRepository()
    {
        //tom liste 
        _employeessList = new List<Employee>();
        // vi tilføjer lokaler her 
        Employee m = new Employee();
        _employeessList.Add(m);
        Employee a = new Employee();
        _employeessList.Add(a);
        Employee g = new Employee();
        _employeessList.Add(g);
        Employee p = new Employee();
        _employeessList.Add(p);

    }

    public List<Employee> GetAll()
    {
        return _employeessList;
        
    }


    public Employee GetById(int id)
    {
        foreach (Employee item in _employeessList )
        {
            if (item.Id == id)
            {
                return item;
            }
        }
        return null;
    }
}