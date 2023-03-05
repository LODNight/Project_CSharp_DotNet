using Microsoft.AspNetCore.Mvc;

namespace Login_Project.Controllers;
[Route("home")]
public class HomeController : Controller
{
    [Route("index")]
    [Route("")]
    [Route("~/")]

    public IActionResult Index()
    {
        return View();
    }
}
