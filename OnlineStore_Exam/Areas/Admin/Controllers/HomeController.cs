﻿using Microsoft.AspNetCore.Mvc;

namespace OnlineStore_Exam.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Orders()
        {
            return View();
        }
    }
}
