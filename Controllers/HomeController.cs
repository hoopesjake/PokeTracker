using Microsoft.AspNetCore.Mvc;

namespace PokeTracker.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}