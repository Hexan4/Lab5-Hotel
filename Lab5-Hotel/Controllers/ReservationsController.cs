using Microsoft.AspNetCore.Mvc;

namespace Lab5_Hotel.Controllers
{
    public class ReservationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
