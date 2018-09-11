using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using JobBoard.Models;
using System;

namespace JobBoard.Controllers
{
  public class JobOpeningController : Controller
  {
    [HttpGet("/jobs")]
    public ActionResult Index()
    {
      List<JobOpening> allJobs = JobOpening.GetAll();
      return View(allJobs);
    }
    [HttpGet("/jobs/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    [HttpPost("/jobs")]
    public ActionResult Create()
    {
      JobOpening allJobs = new JobOpening (Request.Form["new-title"], Request.Form["new-description"], Request.Form["new-contactInfo"]);

      allJobs.Save();
      List<JobOpening> allJobss = JobOpening.GetAll();
      return View("Index", allJobss);
    }


    [HttpPost("/jobs/delete")]
    public ActionResult DeleteAll()
    {
      JobOpening.ClearAll();
      return View();
    }
  }
}
