using Microsoft.AspNetCore.Mvc;

namespace Proj1.Controllers
{
    public class IdentityController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
