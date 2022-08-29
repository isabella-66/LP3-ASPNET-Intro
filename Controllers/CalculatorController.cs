using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ExemploAspNetMvc.Models;

namespace ExemploAspNetMvc.Controllers;

public class CalculatorController : Controller
{
    private readonly ILogger<CalculatorController> _logger;

    public CalculatorController(ILogger<CalculatorController> logger)
    {
        _logger = logger;
    }

    public IActionResult CalculatorOperation()
    {
        return View();
    }

    public IActionResult CalculatorOperationResult([FromForm] Operation operation)
    {
        return View(operation);
    }
}