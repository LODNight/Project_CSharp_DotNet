using Microsoft.AspNetCore.Mvc;

namespace CoffeePeaceful.Controllers;
[Route("contact")]
public class ContactController : Controller
{
    [Route("index")]
    [Route("")]
    public IActionResult Index()
    {
        return View();
    }
}
