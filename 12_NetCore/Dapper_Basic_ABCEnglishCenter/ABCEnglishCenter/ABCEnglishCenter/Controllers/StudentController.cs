using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ABCEnglishCenter.Models;
using ABCEnglishCenter.DAL;
using ABCEnglishCenter.Models.Domain.Request;

namespace ABCEnglishCenter.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentResponsitory studentService = new StudentResponsitory();
      
        public IActionResult Index(string stringSearch )
        {
            return View(studentService.GetStudents(stringSearch));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.languages = studentService.GetLanguages();
            ViewBag.levels = studentService.GetLevels();
            return View();
        }
        [HttpPost]
        public IActionResult Create(StudentCreate studentCreate)
        {
            var createResult = studentService.Create(studentCreate);
            if (createResult > 0)
            {
                TempData["Success"] = "Student has been created success";
            }
            else
            {
                TempData["Error"] = "Something went wrong, please try again later";
            }
            ViewBag.languages = studentService.GetLanguages();
            ViewBag.levels = studentService.GetLevels();
            return View();
        }

        public IActionResult Detail(int id)
        {
            StudentDetail student = studentService.Details(id);
            return View(student);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            ViewBag.languages = studentService.GetLanguages();
            ViewBag.levels = studentService.GetLevels();
            var student = studentService.GetStudentById(id);
            return View(student);
        }
        public IActionResult Update(StudentUpdate student)
        {
            if (ModelState.IsValid)
            {
                studentService.Update(student);
                return RedirectToAction("Index");
            }
            return View(student);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            studentService.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
