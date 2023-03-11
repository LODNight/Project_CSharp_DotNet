using Microsoft.AspNetCore.Mvc;

namespace CoffeePeaceful.Controllers;
[Route("user")]
public class UserController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
