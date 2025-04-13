using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // Every public method in a controller is callable as an HTTP endpoint

    // Controller methods: Are referred to as action methods.For example, the Index action method in the preceding code.
    // Generally return an IActionResult or a class derived from ActionResult, not a type like string.

    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }

    // GET: /HelloWorld/Welcome/ 
    // Requires using System.Text.Encodings.Web;
    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
}