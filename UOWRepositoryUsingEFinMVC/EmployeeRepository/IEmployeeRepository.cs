using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOWRepositoryUsingEFinMVC.DAL;
using UOWRepositoryUsingEFinMVC.GenericRepository;

namespace UOWRepositoryUsingEFinMVC.EmployeeRepository
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        IEnumerable<Employee> GetEmployeesByGender(string Gender);
        IEnumerable<Employee> GetEmployeesByDepartment(string Dept);
    }
}
