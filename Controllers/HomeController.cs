using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Proj1.Models;

namespace Proj1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
     
    public async Task<IActionResult> DashBoard()
    {
        return View();
    }


    public IActionResult ProductMaster()
    {
        return View();
    }

 
}
