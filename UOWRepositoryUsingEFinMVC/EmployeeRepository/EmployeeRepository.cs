using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UOWRepositoryUsingEFinMVC.DAL;
using UOWRepositoryUsingEFinMVC.GenericRepository;
using UOWRepositoryUsingEFinMVC.UnitOfWork;

namespace UOWRepositoryUsingEFinMVC.EmployeeRepository
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(IUnitOfWork<EmployeeDBModel> unitOfWork)
            : base(unitOfWork)
        {
        }
        public EmployeeRepository(EmployeeDBModel context)
            : base(context)
        {
        }
        public IEnumerable<Employee> GetEmployeesByGender(string Gender)
        {
            return Context.Employees.Where(emp => emp.Gender == Gender).ToList();
        }
        public IEnumerable<Employee> GetEmployeesByDepartment(string Dept)
        {
            return Context.Employees.Where(emp => emp.Dept == Dept).ToList();
        }
    }
}