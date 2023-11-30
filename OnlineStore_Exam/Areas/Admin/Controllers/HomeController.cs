using Microsoft.AspNetCore.Mvc;

namespace OnlineStore_Exam.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction(nameof(Orders));
        }

        public IActionResult Orders()
        {
            return View();
        }
    }
}
