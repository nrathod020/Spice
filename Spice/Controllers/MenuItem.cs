using Microsoft.AspNetCore.Mvc;

namespace Spice.Controllers
{
    public class MenuItem : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
