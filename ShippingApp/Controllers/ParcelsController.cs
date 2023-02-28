using Microsoft.AspNetCore.Mvc;
using ShippingApp.Models;
using System.Collections.Generic;


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
      return RedirectToAction("Index");
    }

  }
}