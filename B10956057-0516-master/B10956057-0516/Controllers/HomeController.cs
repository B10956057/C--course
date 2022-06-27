using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B10956057_0516.Models;
using B10956057_0516.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace B10956057_0516.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly Myservice _myService;

        public HomeController(ILogger<HomeController> logger, Myservice myService)
        {
            _logger = logger;
            _myService = myService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}