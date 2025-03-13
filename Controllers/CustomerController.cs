using Microsoft.AspNetCore.Mvc;

namespace Proj1.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Landing()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }
    }
}
