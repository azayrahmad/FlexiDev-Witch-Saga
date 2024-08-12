using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WitchSaga.Core;
using WitchSaga.Web.Models;

namespace WitchSaga.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly BraveProgrammer _calculator;

        public HomeController(BraveProgrammer calculator)
        {
            _calculator = calculator;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(CalculateInputModel input)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", input);
            }

            var personA = new Person(input.AgeOfDeathA, input.YearOfDeathA);
            var personB = new Person(input.AgeOfDeathB, input.YearOfDeathB);

            double result = _calculator.WitchSolver(personA, personB);

            ViewBag.Result = result;

            return View("Index", input);
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