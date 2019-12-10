using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CF_ABCCenter.Context;
using CF_ABCCenter.Models.Languages;
using Microsoft.AspNetCore.Mvc;

namespace CF_ABCCenter.Controllers
{
    public class LanguageController : Controller
    {
        public readonly ABCCenterDbContext _dbContext;
        public LanguageController(ABCCenterDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var languages = _dbContext.Languages.Select(l => new LanguageView()
            {
                LanguageId = l.LanguageId,
                LanguageName = l.LanguageName
            }).ToList();
            return View(languages);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(LanguageAdd model)
        {
            if (ModelState.IsValid)
            {
                var language = new LanguageModel()
                {
                    LanguageName = model.LanguageName
                };
                _dbContext.Add(language);
                if (_dbContext.SaveChanges() > 0)
                {
                    TempData["Message"] = "Language has been added successfully.";
                }
                else
                {
                    TempData["Message"] = "Something went wrong, please contact administrator.";
                }
            }
           
            return View(new LanguageAdd());
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var language = _dbContext.Languages.Find(id);
            _dbContext.Remove(language);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        //public List<LanguageView> GetLanguages()
        //{
        //    var languages = _dbContext.Languages.Select(l => new LanguageView()
        //    {
        //        LanguageId = l.LanguageId,
        //        LanguageName = l.LanguageName
        //    }).ToList();
        //    return languages;
        //}
    }
}