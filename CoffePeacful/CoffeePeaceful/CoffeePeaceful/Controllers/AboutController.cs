using Microsoft.AspNetCore.Mvc;

namespace CoffeePeaceful.Controllers;
[Route("about")]
public class AboutController : Controller
{
    [Route("index")]
    [Route("")]
    public IActionResult Index()
    {
        return View();
    }
}
