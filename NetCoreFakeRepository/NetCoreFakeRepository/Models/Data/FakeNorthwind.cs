using NetCoreFakeRepository.Models.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreFakeRepository.Models.Data
{
    public class FakeNorthwind : IEmployeeRepository
    {
        private List<Employee> employees = new List<Employee>()
        {
            new Employee { ID = 1, Firstname = "Mahmure", Lastname = "Okan",Title="President" },
            new Employee { ID = 2, Firstname = "Sıla", Lastname = "Şirin",Title="Represant" },
            new Employee { ID = 3, Firstname = "Furkan", Lastname = "Güneş",Title="Sales Manager" }
        };

        public List<Employee> GetEmployees()
        {
            return employees.ToList();
        }
    }
}
