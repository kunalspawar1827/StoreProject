using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Proj1.DbContext;

namespace Proj1.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context; 
        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Landing()
        {

           var results = _context.Roles.ToList();
           return View();
        }

        public IActionResult Cart()
        {
            return View();
        }

        
        public IActionResult OrderDetails()
        {
           return View();
        }
    }
}
