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
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace CF_ABCCenter.Controllers
{
    public class HomeController : Controller
    {

        public readonly ABCCenterDbContext _dbContext;

        public HomeController(ABCCenterDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        //public IActionResult Index(string searchString, int? pageNumber)
        //{
        //    // lấy toàn bộ liên kết
        //    var students = (from l in _dbContext.Languages
        //                    join s in _dbContext.Students on l.LanguageId equals s.LanguageId
        //                    join lv in _dbContext.Levels on s.LevelId equals lv.LevelId
        //                    where !s.IsDelete
        //                    select new StudentView
        //                    {
        //                        ID = s.StudentId,
        //                        Name = s.Name,
        //                        DOB = s.DOB,
        //                        Email = s.Email,
        //                        IMG = s.IMG,
        //                        Sex = s.Sex,
        //                        LanguageName = l.LanguageName,
        //                        LevelName = lv.LevelName
        //                    });
        //    if (!String.IsNullOrEmpty(searchString)) //// kiểm tra chuỗi tìm kiếm có rỗng/null hay không
        //    {
        //        students = students.Where(st => st.Name.Contains(searchString)
        //        || st.Email.Contains(searchString)); //lọc theo chuỗi tìm kiếm
        //    }

        //    // paging

        //    if (searchString != null)
        //    {
        //        pageNumber = 1;
        //    }

        //    int pageSize = 3;




        //    return View(students.ToList(), pageNumber ?? 1, pageSize); //trả về kết quả
        //}

        public async Task<IActionResult> Index(string searchString, int? pageNumber, string sortOrder)
        {
            // lấy toàn bộ liên kết
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
                            });

            // search
            if (!String.IsNullOrEmpty(searchString)) //// kiểm tra chuỗi tìm kiếm có rỗng/null hay không
            {
                students = students.Where(st => st.Name.Contains(searchString)
                || st.Email.Contains(searchString)); //lọc theo chuỗi tìm kiếm
            }

            // paging

            if (searchString != null)
            {
                pageNumber = 1;
            }

            int pageSize = 5;

            // Sort
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["LanguageSortParm"] = String.IsNullOrEmpty(sortOrder) ? "language_desc" : "";
            ViewData["LevelSortParm"] = String.IsNullOrEmpty(sortOrder) ? "level_desc" : "";
            switch (sortOrder)
            {
                case "name_desc":
                    students = students.OrderBy(s => s.Name);
                    break;
                case "language_desc":
                    students = students.OrderBy(s => s.LanguageName);
                    break;
                case "level_desc":
                    students = students.OrderBy(s => s.LevelName);
                    break;
            }

            return View(await PaginatedList<StudentView>.CreateAsync(students.AsNoTracking(), pageNumber ?? 1, pageSize)); //trả về kết quả
        }

        public IActionResult Create()
        {
            ViewBag.Levels = GetLevels();
            ViewBag.Languages = GetLanguages();
            return View();
        }
        public static string datamax;
        [HttpPost]
        public IActionResult Create(StudentAdd model)
        {
            if (ModelState.IsValid)
            {
                var files = HttpContext.Request.Form.Files;
                foreach (var Image in files)
                {
                    if (Image != null && Image.Length > 0)
                    {
                        var file = Image;
                        MemoryStream ms = new MemoryStream();
                        file.OpenReadStream().CopyTo(ms);
                        Models.Students.StudentAdd imageEntity = new Models.Students.StudentAdd()
                        {
                            IMG = Convert.ToBase64String(ms.ToArray()),
                        };
                        datamax = imageEntity.IMG;
                    }
                }
                model.IMG = datamax;
                try
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
                }
                catch (Exception)
                {
                    return View();
                }

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
            ViewBag.Levels = GetLevels();
            ViewBag.Languages = GetLanguages();
            return View(studentEdit);
        }

        [HttpPost]
        public IActionResult Edit(StudentEdit model)
        {
            var files = HttpContext.Request.Form.Files;
            foreach (var Image in files)
            {
                if (Image != null && Image.Length > 0)
                {
                    var file = Image;
                    MemoryStream ms = new MemoryStream();
                    file.OpenReadStream().CopyTo(ms);
                    Models.Students.StudentAdd imageEntity = new Models.Students.StudentAdd()
                    {
                        IMG = Convert.ToBase64String(ms.ToArray()),
                    };
                    datamax = imageEntity.IMG;
                }
            }

            model.IMG = datamax;
            if (ModelState.IsValid)
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
            }
            ViewBag.Levels = GetLevels();
            ViewBag.Languages = GetLanguages();
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
    }
}
