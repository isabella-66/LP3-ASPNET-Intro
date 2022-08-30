using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ExemploAspNetMvc.Models;

namespace ExemploAspNetMvc.Controllers;

public class MathOperationsController : Controller
{
    private readonly ILogger<MathOperationsController> _logger;

    public MathOperationsController(ILogger<MathOperationsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Sum()
    {
        return View();
    }

    public IActionResult SumOperation([FromForm] Number number)
    {
        return View(number);
    }

    public IActionResult Sub()
    {
        return View();
    }

    public IActionResult SubOperation([FromForm] Number number)
    {
        return View(number);
    }

    public IActionResult Div()
    {
        return View();
    }

    public IActionResult DivOperation([FromForm] Number number)
    {
        return View(number);
    }

    public IActionResult Mult()
    {
        return View();
    }

    public IActionResult MultOperation([FromForm] Number number)
    {
        return View(number);
    }
}