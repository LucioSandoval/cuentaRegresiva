using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CuentaRegresiva.Models;

namespace CuentaRegresiva.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {   
        DateTime startTime = DateTime.Now;
        DateTime endTime = new DateTime(2023, 11, 3, 7, 0, 0);
        Console.WriteLine(startTime);
        Console.WriteLine(endTime);
        ViewBag.StartTime = startTime;
        ViewBag.EndTime = endTime; 
        TimeSpan timeRemaining = endTime - startTime;

    // Puedes convertir la diferencia de tiempo a un formato más legible si lo deseas
    string formattedTimeRemaining = string.Format("{0} days, {1} hours, {2} minutes, {3} seconds",
        timeRemaining.Days, timeRemaining.Hours, timeRemaining.Minutes, timeRemaining.Seconds);

    ViewBag.TimeRemaining = formattedTimeRemaining;
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
