using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CF_ABCCenter.Context;
using CF_ABCCenter.Models.Languages;
using CF_ABCCenter.Models.Levels;
using Microsoft.AspNetCore.Mvc;

namespace CF_ABCCenter.Controllers
{
    public class LevelController : Controller
    {
        public readonly ABCCenterDbContext _dbContext;
        public LevelController(ABCCenterDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var levels = _dbContext.Levels.Select(l => new LevelView()
            {
                LevelId = l.LevelId,
                LevelName = l.LevelName
            }).ToList();
            return View(levels);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(LevelAdd model)
        {
            if (ModelState.IsValid)
            {
                var level = new LevelModel()
                {
                    LevelName = model.LevelName
                };
                _dbContext.Add(level);
                if (_dbContext.SaveChanges() > 0)
                {
                    TempData["Message"] = "Level has been added successfully.";
                }
                else
                {
                    TempData["Message"] = "Something went wrong, please contact administrator.";
                }
            }
           
            return View(new LevelAdd());
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var level = _dbContext.Levels.Find(id);
            _dbContext.Remove(level);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}