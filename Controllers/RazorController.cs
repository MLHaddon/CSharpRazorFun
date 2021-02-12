using System.Reflection.PortableExecutable;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
namespace RazorFun.Controllers
{
  public class RazorController : Controller
  {
    // Session Vars
    List<string> stuff = new List<string>();

    // Requests and Redirects
    [HttpGet("")]
    public ViewResult Index()
    {
      ViewBag.data = stuff;
      return View();
    }
  }
}