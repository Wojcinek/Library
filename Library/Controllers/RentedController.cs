using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class RentedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
