using Microsoft.AspNetCore.Mvc;
using NetCoreFakeRepository.Models.BaseRepository;
using NetCoreFakeRepository.Models.Data;

namespace NetCoreFakeRepository.Controllers
{
    public class EmployeeController : Controller
    {
        //Dependency Injection
        private IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public IActionResult Index()
        {
            return View(_employeeRepository.GetEmployees());
        }
    }
}
