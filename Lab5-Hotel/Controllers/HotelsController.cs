using Microsoft.AspNetCore.Mvc;

namespace Lab5_Hotel.Controllers
{
    public class HotelsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Reservation()
        {
            return View();
        }

    }
}
