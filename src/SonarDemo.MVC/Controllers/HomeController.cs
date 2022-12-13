using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SonarDemo.MVC.Models;

namespace SonarDemo.MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var list = new List<string>{
            "Dotnet", "MVC", "Angular", "Testes Unitários"
        };
        return View(list);
    }

    public IActionResult Privacy()
    {
        var list = new List<string>{
            "Dotnet", "MVC", "Angular", "Testes Unitários"
        };
        return View(list);
    }

     public IActionResult MinhaLista()
    {
        var list = new List<string>{
            "Dotnet", "MVC", "Angular", "Testes Unitários"
        };
        return View(list);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
