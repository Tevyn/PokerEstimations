using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PokerEstimations.Models;
using PokerEstimations.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PokerEstimations.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Dependency injection here 
            var deckService = new DeckService();
            var model = new Drill(deckService);
            return View(model);
        }

        [HttpPost]
        public IActionResult Guess(string[] pocketCards, double guess)
        {
            var calculateEquitySerice = new CalculateEquityService();
            var result = calculateEquitySerice.CalculateEquity(pocketCards)[0];
            var diff = result - guess;
            bool correct = diff < 5 && diff > -5;


            return RedirectToAction("CheckAnswer", correct);
        }

        public IActionResult CheckAnswer(bool correct)
        {
            if (correct)
            {
                ViewBag.CheckAnswerMessage = "Close enough";
            }
            else
            {
                ViewBag.CheckAnswerMessage = "Wrong";
            }
            return View();
        }


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
