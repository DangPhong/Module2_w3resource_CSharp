using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DatabaseFisrt_CRUD.Models;
using DatabaseFisrt_CRUD.Context;

namespace DatabaseFisrt_CRUD.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeContext _dbContext;
        public HomeController(EmployeeContext dbContext)
        {
            _dbContext = dbContext;
        }


        public IActionResult Index()
        {
            var _emplst = _dbContext.tblEmployees.
                            Join(_dbContext.tblSkills, e => e.SkillID, s => s.SkillID,
                            (e, s) => new EmployeeViewModel
                            {
                                EmployeeID = e.EmployeeID,
                                EmployeeName = e.EmployeeName,
                                PhoneNumber = e.PhoneNumber,
                                Skill = s.Title,
                                YearsExperience = e.YearsExperience
                            }).ToList();
            IList<EmployeeViewModel> emplst = _emplst;
            return View(emplst);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Skills = GetSkills();
            return View();
        }
        [HttpPost]

        public IActionResult Create(EmployeeCreateModel model)
        {
            var _employee = new tblEmployee()
            {
                EmployeeID = model.EmployeeID,
                EmployeeName = model.EmployeeName,
                PhoneNumber = model.PhoneNumber,
                SkillID = model.SkillID,
                YearsExperience = model.YearsExperience
            };
            _dbContext.tblEmployees.Add(_employee);
            if (_dbContext.SaveChanges() > 0)
            {
                TempData["Message"] = "Employee has been added successfully.";
            }
            else
            {
                TempData["Message"] = "Something went wrong, please contact administrator.";
            }
            ViewBag.Skills = GetSkills();
            return View(new EmployeeCreateModel());
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var employee = _dbContext.tblEmployees.Find(id);
            _dbContext.Remove(employee);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var _employee = _dbContext.tblEmployees.Where(e => e.EmployeeID == id).FirstOrDefault();
            var employeeeEdit = new EmployeeEditModel()
            {
                EmployeeID = _employee.EmployeeID,
                EmployeeName = _employee.EmployeeName,
                PhoneNumber = _employee.PhoneNumber,
                SkillID = _employee.SkillID,
                YearsExperience = _employee.YearsExperience
            };
            ViewBag.Skills = GetSkills();
            return View(employeeeEdit);
        }
        
        [HttpPost]
        public IActionResult Edit(EmployeeEditModel model)
        {
            var employee = _dbContext.tblEmployees.Find(model.EmployeeID);
            employee.EmployeeName = model.EmployeeName;
            employee.PhoneNumber = model.PhoneNumber;
            employee.SkillID = model.SkillID;
            employee.YearsExperience = model.YearsExperience;
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var _employees = _dbContext.tblEmployees.
                            Join(_dbContext.tblSkills, e => e.SkillID, s => s.SkillID,
                            (e, s) => new EmployeeViewModel
                            {
                                EmployeeID = e.EmployeeID,
                                EmployeeName = e.EmployeeName,
                                PhoneNumber = e.PhoneNumber,
                                Skill = s.Title,
                                YearsExperience = e.YearsExperience
                            }).Where(e => e.EmployeeID == id).FirstOrDefault();
            return View(_employees);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private List<SkillModel> GetSkills()
        {
            var skills = _dbContext.tblSkills.Select(s => new SkillModel()
            {
                Name = s.Title,
                Value = s.SkillID
            }).ToList();
            return skills;
        }

    }
}
