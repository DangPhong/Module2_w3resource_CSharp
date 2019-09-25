using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CodeFirst_CRUD.Models;
using CodeFirst_CRUD.Context;

namespace CodeFirst_CRUD.Controllers
{
    public class HomeController : Controller
    {
        public readonly EmployeeDbContext _dbContext;
        public HomeController(EmployeeDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var _emp = _dbContext.Employees.Select(e => new EmployeeViewModel()
            {
                EmployeeId = e.EmployeeId,
                Name = e.Name,
                Address = e.Address,
                Avatar = e.Avatar,
                CompanyName = e.CompanyName,
                Designation = e.Designation,
                Salary = e.Salary
            }).ToList();
            return View(_emp);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(EmployeeCreateModel model)
        {
            var _employee = new Employee()
            {
                EmployeeId = model.EmployeeId,
                Name = model.Name,
                Address = model.Address,
                CompanyName = model.CompanyName,
                Avatar = model.Avatar,
                Designation = model.Designation,
                Salary = model.Salary
            };
            _dbContext.Employees.Add(_employee);
            if (_dbContext.SaveChanges() > 0)
            {
                TempData["Message"] = "Employee has been added successfully.";
            }
            else
            {
                TempData["Message"] = "Something went wrong, please contact administrator.";
            }
            return View(new EmployeeCreateModel());
        }

        public IActionResult Details(int id)
        {
            var _employees = _dbContext.Employees.Select(e => new EmployeeDetailModel()
            {
                EmployeeId = e.EmployeeId,
                Name = e.Name,
                CompanyName = e.CompanyName,
                Address = e.Address,
                Designation = e.Designation,
                Avatar = e.Avatar,
                Salary = e.Salary
            }).Where(e => e.EmployeeId == id).FirstOrDefault(); ;
            return View(_employees);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var _employee = _dbContext.Employees.Where(e => e.EmployeeId == id).FirstOrDefault();
            var employeeEdit = new EmployeeEditModel()
            {
                EmployeeId = _employee.EmployeeId,
                Name = _employee.Name,
                Address = _employee.Address,
                CompanyName = _employee.CompanyName,
                Avatar = _employee.Avatar,
                Designation = _employee.Designation,
                Salary = _employee.Salary
            };
            return View(employeeEdit);
        }

        [HttpPost]
        public IActionResult Edit(EmployeeEditModel model)
        {
            var employee = _dbContext.Employees.Find(model.EmployeeId);
            employee.Name = model.Name;
            employee.Address = model.Address;
            employee.Avatar = model.Avatar;
            employee.Designation = model.Designation;
            employee.CompanyName = model.CompanyName;
            employee.Salary = model.Salary;
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete (int id)
        {
            var _employee = _dbContext.Employees.Find(id);
            _dbContext.Remove(_employee);
            _dbContext.SaveChanges();
            return RedirectToAction("index");
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
