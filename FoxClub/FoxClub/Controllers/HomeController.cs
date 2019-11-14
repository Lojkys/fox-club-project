using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxClub.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoxClub.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFoxService foxService;

        public HomeController(IFoxService foxService)
        {
            this.foxService = foxService;
        }

        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                string text = "";
                return View("login", text);
            }
            if (!foxService.ListOfFoxes.Any(f => f.Name.Equals(name)))
            {
                Fox fox = new Fox(name);
                foxService.AddFoxToDatabase(fox);
                var text = $"A new fox with name {name} was added to the database.";
                return View("login", text);
            }
            else
            {              
                return RedirectToAction("information", "Home", foxService.ListOfFoxes.Where(f=>f.Name == name).ToList()[0]);
            }            
        }        

        [Route("nutritionstore")]
        public IActionResult NutritionStore(Fox fox)
        {
            return View(fox);
        }
       
        [HttpPost("nutritionstore")]
        public IActionResult NutritionStore(string food, string drink, string name)
        {
            var currentFox = foxService.GetFoxByName(name);
            currentFox.AddFood(food);
            currentFox.AddDrink(drink);

            return RedirectToAction("information", "Home", currentFox);
        }

        [Route("trickcenter")]
        public IActionResult TrickCenter(Fox fox)
        {
            return View(fox);
        }

        [HttpPost("trickcenter")]
        public IActionResult TrickCenter(string trick, string name)
        {
            var currentFox = foxService.GetFoxByName(name);
            currentFox.AddTrick(trick);

            if (currentFox.ListOfTricks.Contains(trick))
            {
                return RedirectToAction("information", "Home", currentFox);
            }
            else
            {
                currentFox.AddTrick(trick);
                return RedirectToAction("information", "Home", currentFox); 
            }
        }

        [Route("information")]
        public IActionResult Information(Fox fox)
        {
            return View(fox);
        }
    }
}