﻿using Microsoft.AspNetCore.Mvc;

namespace UdemyIdentity.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
