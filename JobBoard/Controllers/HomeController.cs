using Microsoft.AspNetCore.Mvc;
using Job.Models;
using System.Collections.Generic;

namespace Job.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/packages/new")]
    public ActionResult CreateForm()
    {
        return View();
    }
  }
}