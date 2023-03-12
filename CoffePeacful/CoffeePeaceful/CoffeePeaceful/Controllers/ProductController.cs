using Microsoft.AspNetCore.Mvc;

namespace CoffeePeaceful.Controllers;
[Route("product")]
public class ProductController : Controller
{
    [Route("index")]
    [Route("")]
    public IActionResult Index()
    {
        return View();
    }
}
