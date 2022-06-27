using B10956057_webapi.Models;
using B10956057_webapi.service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static B10956057_webapi.Controllers.LoginControler;

namespace B10956057_webapi.Controllers
{
    [FncodeAuthorize(AuthFnCodeEnum.StudentMgr)]
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IActionResult Index(Dictionary<string, string> queryDic, int nowPage = 1)
        {
            int count = 10;
            int offset = (nowPage - 1) * count;
            var (total, list) = _studentService.GetStudents(offset, count);
            ViewData["Total"] = total;
            ViewData["nowPage"] = nowPage;

            
            return View(list);
        }

        public IActionResult Update(string studentNo)
        {
            var student = _studentService.GetStudentByStudentNo(studentNo);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost]
        public IActionResult Update()
        {
                return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Student student)
        {
            if (ModelState.IsValid)
            {
                _studentService.UpdateStudent(student);
                return RedirectToAction("Index");
            }
            return View(student);
        }

       

        public IActionResult Delete(string studentNo)
        {
            var student = _studentService.GetStudentByStudentNo(studentNo);
            
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(string studentNo)
        {
            _studentService.DeleteStudent(studentNo);
            return RedirectToAction("Index");
        }

        
        [Authorize(Roles ="admin")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin")]
        public IActionResult Create(Student student)
        {
            _studentService.CreateStudent(student);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Detail(string studentNo)
        {
            var student = _studentService.GetStudentByStudentNo(studentNo);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

    }
}
