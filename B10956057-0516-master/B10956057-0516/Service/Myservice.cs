using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace B10956057_0516.Service
{
    public class Myservice : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
