using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int yearFrom, int yearTo)
        {
            return RedirectToAction("Results", new { yearFrom, yearTo });
        }



        //might be a get
        [HttpGet]
        public IActionResult Results(int yearFrom, int yearTo)
        {
            return View(TimePerson.GetPersons(yearFrom, yearTo));

        }


        public string Test(string name, int age)
        {
            return $"Hello {name}, you're {age} years old";
        }
    }
}
