using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

            return View(_context.Categories.Include(x => x.Image));
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

        [HttpGet]
        public IActionResult Search(string searchStr)
        {
            if (!string.IsNullOrWhiteSpace(searchStr))
            {
                var posts = _context.Products.Include(x => x.Images)
                                           .Include(x => x.Category)
                                           .Where(x => x.Title.Contains(searchStr));
                return View(posts);
            }
            return View();
        }

        [HttpGet]
        public IActionResult SearchByCategory(int id)
        {
            var posts = _context.Products.Include(x => x.Category).Where(p => p.CategoryId == id);
            var category = _context.Categories.First(c => c.Id == id);
            
            return View(posts);
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