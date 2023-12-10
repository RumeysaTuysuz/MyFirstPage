using Microsoft.AspNetCore.Mvc;

namespace MyFirstPage.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
