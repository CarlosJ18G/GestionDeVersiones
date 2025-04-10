using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GestionDeVersiones.Models;

namespace GestionDeVersiones.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    /// <summary>
    /// Accion que se encarga de...
    /// </summary>
    /// <returns>View</returns>
    public IActionResult ProgramacionWeb()
    {
        return View();
    }

    public IActionResult Commit2()
    {
        return View();
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
