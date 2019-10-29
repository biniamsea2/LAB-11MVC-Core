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
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int year, string honor, string name, string country, int birthYear, int deathYear, string title, string category, string context)
        {
            TimePerson person = new TimePerson(year,  honor,  name,  country,  birthYear,  deathYear,  title,  category,  context);
            return RedirectToAction("Results", person);
        }

        public ViewResult Results(TimePerson person)
        {
            return View(person);
        }


        public string Test(string name, int age)
        {
            return $"Hello {name}, you're {age} years old";
        }
    }
}
