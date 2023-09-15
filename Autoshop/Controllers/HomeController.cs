﻿using System.Diagnostics;
using Autoshop.DAL.Interfaces;
using Autoshop.Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using Autoshop.Models;

namespace Autoshop.Controllers;

public class HomeController : Controller
{
    
    public async Task<IActionResult> Index()
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