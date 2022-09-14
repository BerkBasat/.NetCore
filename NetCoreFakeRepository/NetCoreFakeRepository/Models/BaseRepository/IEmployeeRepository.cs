using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreFakeRepository.Models.BaseRepository
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployees();
    }
}
