using Microsoft.AspNetCore.Mvc;
using OnlineStore_Exam.Models;
using System.Diagnostics;

namespace OnlineStore_Exam.Controllers
{
    public class HomeController : Controller
    {
        private readonly OnlineStoreDbContext _context;

        public HomeController(OnlineStoreDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Shop()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Search()
        {
            return View();
        }

        public IActionResult Basket()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
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