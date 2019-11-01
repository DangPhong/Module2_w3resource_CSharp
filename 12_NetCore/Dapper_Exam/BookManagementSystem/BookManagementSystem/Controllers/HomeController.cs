using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookManagementSystem.Models;
using BookManagementSystem.DAL;
using BookManagementSystem.Models.Domain.Request;
using BookManagementSystem.Models.Domain.Response;

namespace BookManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly BookResponsitory bookResponsitory = new BookResponsitory();
        public IActionResult Index()
        {
            return View(bookResponsitory.GetBooks());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.catelories = bookResponsitory.GetCatelories();
            return View();
        }
        [HttpPost]
        public IActionResult Create(BookCreate bookCreate)
        {
            var createResult = bookResponsitory.Create(bookCreate);
            if (createResult > 0)
            {
                TempData["Success"] = "Group meeting has been created success";
            }
            else
            {
                TempData["Error"] = "Something went wrong, please try again later";
            }
            ViewBag.catelories = bookResponsitory.GetCatelories();
            return View();
        }
        [HttpGet]
        public IActionResult Detail(int id)
        {
            BookDetail book = bookResponsitory.Details(id);
            return View(book);
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            var book = bookResponsitory.GetBookById(id);
            ViewBag.catelories = bookResponsitory.GetCatelories();
            return View(book);
        }
        [HttpPost]
        public IActionResult Update(BookUpdate book)
        {
            if (ModelState.IsValid)
            {
                bookResponsitory.Update(book);
                return RedirectToAction("Index");
            }
            //  ViewBag.CateloryView = bookResponsitory.GetBooks();
            ViewBag.catelories = bookResponsitory.GetCatelories();
            return View(book);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            bookResponsitory.Delete(id);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Search(string stringSearch)
        {
            var search = bookResponsitory.Search(stringSearch);
            return View(search);
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
        //[HttpPost]

    }
}
