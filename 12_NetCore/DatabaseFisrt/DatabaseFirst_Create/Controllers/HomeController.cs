using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DatabaseFirst_Create.Models;

namespace DatabaseFirst_Create.Controllers
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
    }
}