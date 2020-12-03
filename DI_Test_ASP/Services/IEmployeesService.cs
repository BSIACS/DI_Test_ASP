using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;

namespace DI_Test_ASP.Services
{
    public interface IEmployeesService
    {
        public IEnumerable<Employee> GetEmployees();

        public void AddEmployee(Employee employee);
    }
}
