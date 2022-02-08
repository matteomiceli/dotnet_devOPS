using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebAppTemp.Models;

namespace WebAppTemp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var temp = new TemperatureModel("l", "l", 0);
        return View(temp);
    }

    [HttpPost]
    public IActionResult Index(string TempFrom, string TempTo, string InitialValue)
    {
        var temp = new TemperatureModel(TempFrom, TempTo, int.Parse(InitialValue));

        return View(temp);
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

