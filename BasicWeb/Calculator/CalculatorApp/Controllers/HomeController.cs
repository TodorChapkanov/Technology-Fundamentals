using CalculatorApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index(Calculator calculator)
        {
            return View(calculator);
        }
        [HttpPost]
        public IActionResult Calculate(Calculator calculator)
        {

            calculator.CalculateResult();

            Data.CalculatorHistory.Add(calculator);
           
            return RedirectToAction("Index", calculator);
        }
        public IActionResult History (Calculator calculator)
        {
            return View(Data.CalculatorHistory);
        }
    }
}
