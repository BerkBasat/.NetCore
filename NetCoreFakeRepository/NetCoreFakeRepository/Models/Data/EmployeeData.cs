using NetCoreFakeRepository.Models.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreFakeRepository.Models.Data
{
    public class EmployeeData:IEmployeeRepository
    {
        private List<Employee> employees = new List<Employee>()
        {
            new Employee { ID = 1, Firstname = "Andrew", Lastname = "Fuller",Title="President" },
            new Employee { ID = 2, Firstname = "Nancy", Lastname = "Davoilo",Title="Represant" },
            new Employee { ID = 3, Firstname = "Anne", Lastname = "Dothsworths",Title="Sales Manager" }
        };

        public List<Employee> GetEmployees()
        {
            return employees.ToList();
        }
    }
}
