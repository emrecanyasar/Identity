using Microsoft.AspNetCore.Mvc;

namespace UdemyIdentity.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
