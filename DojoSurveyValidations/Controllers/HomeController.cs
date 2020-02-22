using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Day5.Models;
using System.ComponentModel.DataAnnotations;

namespace Day5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // [HttpPost("survey")]
        // public IActionResult Submission(string name, string location, string language, string comment)
        // {
        //     ViewBag.name = name;
        //     ViewBag.location = location;
        //     ViewBag.language = language;
        //     ViewBag.comment = comment;
        //     return View("results");

        //     // Handle your form submission here
        // }

        [HttpPost("survey")]
        public IActionResult survey(Survey fromForm)
        {
            if (ModelState.IsValid)
            {
                return View("results", fromForm);
            }
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
