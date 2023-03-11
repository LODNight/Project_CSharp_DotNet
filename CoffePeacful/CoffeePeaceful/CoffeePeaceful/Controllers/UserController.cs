using Microsoft.AspNetCore.Mvc;

namespace CoffeePeaceful.Controllers;
public class UserController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
