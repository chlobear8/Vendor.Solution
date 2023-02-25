using Microsoft.AspNetCore.Mvc;
using Vendor.Models;
using System.Collections.Generic;
using System;

namespace Vendor.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendors> allVendors = Vendors.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName)
    {
      Vendors newVendor = new Vendors(vendorName);
      return RedirectToAction("Index");
    }

    [HttpPost("/vendors/delete")]
    public ActionResult DeleteAll()
    {
      Vendors.ClearAll();
      return View();
    }
  }
}