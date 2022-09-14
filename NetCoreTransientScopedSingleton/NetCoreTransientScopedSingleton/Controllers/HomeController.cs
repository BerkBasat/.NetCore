using Microsoft.AspNetCore.Mvc;
using NetCoreTransientScopedSingleton.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreTransientScopedSingleton.Controllers
{
    public class HomeController : Controller
    {
        //Transient
        private readonly ITransient _transientService1;
        private readonly ITransient _transientService2;

        //Scoped
        private readonly IScoped _scopedService1;
        private readonly IScoped _scopedService2;

        //Singleton
        private readonly ISingleton _singletonService1;
        private readonly ISingleton _singletonService2;


        public HomeController(ITransient transientService1, ITransient transientService2, IScoped scopedService1, IScoped scopedService2, ISingleton singletonService1, ISingleton singletonService2)
        {
            //Transient injection
            _transientService1 = transientService1;
            _transientService2 = transientService2;

            //Scoped injection
            _scopedService1 = scopedService1;
            _scopedService2 = scopedService2;

            //Singleton injection
            _singletonService1 = singletonService1;
            _singletonService2 = singletonService2;

        }
        public IActionResult Index()
        {


            //Transient ViewBag
            ViewBag.TransientService1 = _transientService1.GetOperation();
            ViewBag.TransientService2 = _transientService2.GetOperation();

            //Scoped ViewBag
            ViewBag.ScopedService1 = _scopedService1.GetOperation();
            ViewBag.ScopedService2 = _scopedService2.GetOperation();

            //Singleton ViewBag
            ViewBag.SingletonService1 = _singletonService1.GetOperation();
            ViewBag.SingletonService2 = _singletonService2.GetOperation();




            return View();
        }

       
    }
}
