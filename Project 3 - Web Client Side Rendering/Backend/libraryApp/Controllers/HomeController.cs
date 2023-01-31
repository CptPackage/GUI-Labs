using Microsoft.AspNetCore.Mvc;

namespace libraryApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}