using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using UdemyIdentity.Models;

namespace UdemyIdentity.Controllers
{
    public class AdminController1 : Controller
    {
        private UserManager<AppUser> userManager { get;}
        public AdminController1(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }
        [Route("Admin")]
        public IActionResult Index()
        {
            return View(userManager.Users.ToList());
        }
    }
}
