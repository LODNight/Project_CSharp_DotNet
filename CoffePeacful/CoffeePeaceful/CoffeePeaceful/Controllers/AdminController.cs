using Microsoft.AspNetCore.Mvc;

namespace CoffeePeaceful.Controllers;
[Route("admin")]
public class AdminController : Controller
{
    [Route("index")]
    [Route("~/")]
    [Route("")]
    public IActionResult Index()
    {
        //AASD
        return View();
    }

    [Route("login")]
    public IActionResult Login()
    {
        //AASD
        return View();
    }
}
