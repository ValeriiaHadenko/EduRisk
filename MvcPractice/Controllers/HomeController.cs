using System;
using System.Diagnostics;
using CsvHelper.Configuration;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using MvcPractice.Models;
using MvcPractice.Services;
using CsvHelper;

namespace MvcPractice.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IEnumerable<Student> students = CSVService.ReadCSV<Student>("wwwroot/data/new_data.csv");

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [Route("")]
    public IActionResult Index() => View();

    [Route("students")]
    public IActionResult Student()
    {
        return View(students);
    }

    [Route("student/{id}")]
    public IActionResult Details(string id)
    {
        var student = students.FirstOrDefault(s => s.ID == id);

        if (student == null)
        {
            return NotFound();
        }

        return View(student);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }


}

