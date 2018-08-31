using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BartenderFinal.Models;

namespace BartenderFinal.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult DrinkForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult DrinkForm (DrinkOrder drink)
        {
            return View("ConfirmationPage", drink);
        }
        
        public ViewResult ConfirmationPage(DrinkOrder drink)
        {
            return View("Thanks", drink);
        }

       
        
        //blah -------------------------------------------------

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
