using Microsoft.AspNetCore.Mvc;

namespace MVC_example.Controllers
{
    public class PriceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MIS() {
            return View();
        }
}
