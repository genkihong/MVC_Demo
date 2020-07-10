using MVC_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.Controllers
{
  public class CustomerController : Controller
  {
    // GET: Customer
    public ActionResult Index()
    {
      return View();
      //return Content("This is Index action method of CustomerController");
    }
    [HttpPost]
    public ActionResult Index(Customer customer)
    {
      return View(customer);
    }

    public ActionResult Who(int? id)
    {
      return Content($"ID is {id}");
    }
  }
}