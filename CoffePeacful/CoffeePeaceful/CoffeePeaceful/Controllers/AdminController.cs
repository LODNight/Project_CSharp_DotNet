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
        //123
        //hello
        //i feel so good
        return View();
    }
}
