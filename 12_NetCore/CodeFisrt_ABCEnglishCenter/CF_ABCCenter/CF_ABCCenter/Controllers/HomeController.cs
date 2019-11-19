using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CF_ABCCenter.Models;
using CF_ABCCenter.Context;
using CF_ABCCenter.Models.Students;
using CF_ABCCenter.Models.Languages;
using CF_ABCCenter.Models.Levels;

namespace CF_ABCCenter.Controllers
{
    public class HomeController : Controller
    {
        public readonly ABCCenterDbContext _dbContext;
        public HomeController(ABCCenterDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var students = (from l in _dbContext.Languages
                            join s in _dbContext.Students on l.LanguageId equals s.LanguageId
                            join lv in _dbContext.Levels on s.LevelId equals lv.LevelId
                            where !s.IsDelete
                            select new StudentView
                            {
                                ID = s.StudentId,
                                Name = s.Name,
                                DOB = s.DOB,
                                Email = s.Email,
                                IMG = s.IMG,
                                Sex = s.Sex,
                                LanguageName = l.LanguageName,
                                LevelName = lv.LevelName
                            }).ToList();
            return View(students);
        }
        
        public IActionResult Create()
        {
            ViewBag.Levels = GetLevels();
            ViewBag.Languages = GetLanguages();
            return View();
        }
        [HttpPost]
        public IActionResult Create(StudentAdd model)
        {
            var student = new StudentModel()
            {
                //StudentId = model.StudentId,
                Name = model.Name,
                IMG = model.IMG,
                DOB = model.DOB,
                Email = model.Email,
                Sex = model.Sex,
                LanguageId = model.LanguageId,
                LevelId = model.LevelId
            };
            _dbContext.Add(student);
            if (_dbContext.SaveChanges() > 0)
            {
                TempData["Message"] = "Student has been added successfully.";
            }
            else
            {
                TempData["Message"] = "Something went wrong, please contact administrator.";
            }
            ViewBag.Levels = GetLevels();
            ViewBag.Languages = GetLanguages();
            return View(new StudentAdd());
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var student = _dbContext.Students.Find(id);
            student.IsDelete = true;
            _dbContext.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Details(int id)
        {
            var student = (from l in _dbContext.Languages
                           join s in _dbContext.Students on l.LanguageId equals s.LanguageId
                           join lv in _dbContext.Levels on s.LevelId equals lv.LevelId
                           select new StudentDetail
                           {
                               ID = s.StudentId,
                               Name = s.Name,
                               DOB = s.DOB,
                               IMG = s.IMG,
                               Email = s.Email,
                               Sex = s.Sex,
                               LanguageName = l.LanguageName,
                               LevelName = lv.LevelName
                           }).Where(s => s.ID == id).FirstOrDefault();
            return View(student);
        }

        public IActionResult Edit(int id)
        {
            var student = _dbContext.Students.Where(s => s.StudentId == id).FirstOrDefault();
            var studentEdit = new StudentEdit()
            {
                StudentId = student.StudentId,
                Name = student.Name,
                IMG = student.IMG,
                DOB = student.DOB,
                Email = student.Email,
                Sex = student.Sex,
                LanguageId = student.LanguageId,
                LevelId = student.LevelId
            };
            return View(studentEdit);
        }

        [HttpPost]
        public IActionResult Edit(StudentEdit model)
        {
            var student = _dbContext.Students.Find(model.StudentId);
            student.Name = model.Name;
            student.IMG = model.IMG;
            student.Email = model.Email;
            student.DOB = model.DOB;
            student.Sex = model.Sex;
            student.LanguageId = model.LanguageId;
            student.LevelId = model.LevelId;
            _dbContext.SaveChanges();
            return RedirectToAction("index");
        }

        public List<LevelView> GetLevels()
        {
            var levels = _dbContext.Levels.Select(lv => new LevelView()
            {
                LevelId = lv.LevelId,
                LevelName = lv.LevelName
            }).ToList();
            return levels;
        }

        public List<LanguageView> GetLanguages()
        {
            var languages = _dbContext.Languages.Select(l => new LanguageView()
            {
                LanguageId = l.LanguageId,
                LanguageName = l.LanguageName
            }).ToList();
            return languages;
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
