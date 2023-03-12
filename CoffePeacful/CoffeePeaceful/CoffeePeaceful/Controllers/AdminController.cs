using Microsoft.AspNetCore.Mvc;

namespace CoffeePeaceful.Controllers;
[Route("admin")]
public class AdminController : Controller
{
    [Route("index")]
    [Route("")]
    //[Route("~/")]
    public IActionResult Index()
    {
        return View();
    }

    [Route("login")]
    public IActionResult Login()
    {
        return View();
    }
}
