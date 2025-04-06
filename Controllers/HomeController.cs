using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Website.Helpers;
using Website.Models;

namespace Website.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        int Age = AgeHelper.Calculate(new DateTime(2001,4, 6));
        int DeveloperAge = AgeHelper.Calculate(new DateTime(2023, 2, 28));

        AgeModel model = new AgeModel()
        {
            MyAge = Age,
            DeveloperAge = DeveloperAge
        };

        ViewBag.Age = Age;
        ViewBag.DeveloperAge = DeveloperAge;
        return View(model);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
