using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B10956057_0516.Service;
using Microsoft.AspNetCore.Mvc;


namespace B10956057_0516.Controllers
{
    public class StudentControllers : Controller
    {
        private readonly IStudentService _studentService;

        public StudentControllers(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public IActionResult Index()
        {
            var list = _studentService.GetStudents();
            return View(list);
        }


    }
}
