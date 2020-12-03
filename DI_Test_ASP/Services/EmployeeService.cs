using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Data;
using WebStore.Models;

namespace DI_Test_ASP.Services
{
    public class EmployeeService : IEmployeesService
    {
        public EmployeeService()
        {            
        }

        public IEnumerable<Employee> GetEmployees() => EmployeesInfoProvider.Employees;

        public void AddEmployee(Employee employee)
        {
            EmployeesInfoProvider.Employees = EmployeesInfoProvider.Employees.Append<Employee>(employee);
        }
    }
}
