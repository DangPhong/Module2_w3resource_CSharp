using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DatabaseFisrt.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DatabaseFisrt.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeContext _dbContext;

        public HomeController(EmployeeContext dbContext)
        {
            _dbContext = dbContext;
        }


        // GET: /<controller>/
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

        public IActionResult Create()
        {
            return View();
        }
    }
}
