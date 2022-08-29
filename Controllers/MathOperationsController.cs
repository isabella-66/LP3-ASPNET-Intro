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

<<<<<<< HEAD
    public IActionResult DivOperation([FromForm] Number number)
    {
        return View(number);
    }

    public IActionResult Mult()
=======
    public IActionResult Sub()
>>>>>>> 3d42094a8cba8d1b05c08086cef828fc8efeebdd
    {
        return View();
    }

<<<<<<< HEAD
    public IActionResult MultOperation([FromForm] Number number)
    {
        return View(number);
=======
    public IActionResult SubOperation([FromForm] double numberOne, [FromForm] double numberTwo) 
    {
        ViewBag.NumberOne = numberOne;
        ViewBag.NumberTwo = numberTwo;
        ViewBag.Result = numberOne - numberTwo;
        return View();
>>>>>>> 3d42094a8cba8d1b05c08086cef828fc8efeebdd
    }
}