using System.Reflection.PortableExecutable;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
namespace RazorFun.Controllers
{
  public class RazorController : Controller
  {
    // Requests and Redirects
    [HttpGet("")]
    public ViewResult Index()
    {
      return View();
    }
  }
}