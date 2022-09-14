using System.Collections;
using Microsoft.AspNetCore.Mvc;

namespace Net6Identity.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}