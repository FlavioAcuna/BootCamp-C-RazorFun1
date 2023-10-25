using Microsoft.AspNetCore.Mvc;

namespace HomeController.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    [Route("")]
    public ViewResult Index()
    {
        return View("index");
    }
}