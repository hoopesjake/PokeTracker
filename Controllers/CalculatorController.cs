using Microsoft.AspNetCore.Mvc;

namespace PokeTracker.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
