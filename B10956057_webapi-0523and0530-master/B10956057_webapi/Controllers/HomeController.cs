using B10956057_webapi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using B10956057_webapi.service;

namespace B10956057_webapi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyCustomService _myCustomService;

        public HomeController(ILogger<HomeController> logger, MyCustomService myCustomService)
        {
            _logger = logger;
            _myCustomService = myCustomService;
        }

        public IActionResult Index()
        {
            ViewData["_myCustomService"] = _myCustomService.serviceName;
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
