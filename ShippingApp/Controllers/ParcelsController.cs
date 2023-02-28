using Microsoft.AspNetCore.Mvc;
using ShippingApp.Models;
using System.Collections.Generic;
using System;


namespace ShippingApp.Controllers
{
  public class ParcelsController : Controller
  {

    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      List<Parcel> allParcels = Parcel.GetAll();
      return View(allParcels);
    }

    [HttpGet("/parcels/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult Create(string description, int length, int width, int height, int weight)
    {
      Parcel myParcel = new Parcel(description, length, width, height, weight);
      Console.WriteLine("end of create");
      return RedirectToAction("Index");
    }
  
  [HttpPost("/parcels/delete")]
    public ActionResult DeleteAll()
    {
      Parcel.ClearAll();
      return View();
    }

  [HttpPost("/parcels/shipped")]
    public ActionResult Shipped(string passIn)
    {
      Console.WriteLine(passIn);
      Parcel.ShipParcel(passIn);
      return View();
    }

  }
}