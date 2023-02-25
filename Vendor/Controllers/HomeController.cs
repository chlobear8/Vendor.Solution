using Microsoft.AspNetCore.Mvc;
using Vendor.Models;

namespace Vendor.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      Vendors newVendor = new Vendors("Add vendor to Vendor List");
      return View(newVendor);
    }

    [Route("/vendors/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [Route("/vendors")]
    public ActionResult Create(string vendorName)
    {
      Vendors newVendor = new Vendors(vendorName);
      return View("Index", newVendor);
    }
  }
}