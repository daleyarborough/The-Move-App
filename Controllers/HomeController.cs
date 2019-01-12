using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); 
        }

        public IActionResult BigO()
        {
            ViewData["Message"] = "Big O Notation";

            return View();
        }

        public IActionResult DataStructures()
        {
            ViewData["Message"] = "Data Structures Page";

            return View();
        }

        public IActionResult Algorithms()
        {
            ViewData["Message"] = "Algorithms Page";

            return View();
        }

        public IActionResult OOP()
        {
            ViewData["Message"] = "OOP Fundamentals";

            return View();
        }

        public IActionResult DesignPatterns()
        {
            ViewData["Message"] = "Design Patterns";

            return View();
        }

        public IActionResult FrontEnd()
        {
            ViewData["Message"] = "Front-End Architecture";

            return View();
        }

        public IActionResult Other()
        {
            ViewData["Message"] = "OOP Fundamentals";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
