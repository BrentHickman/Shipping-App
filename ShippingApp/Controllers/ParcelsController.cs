using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;


namespace ToDoList.Controllers
{
  public class ItemsController : Controller
  {

    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      List<Item> allItems = Item.GetAll();
      return View(allItems);
    }

    [HttpGet("/parcels/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult Create(string description, int length, int width, int height, int weight)
    {
      Parcel myParcek = new Parcel(description, length, width, height, weight);
      return RedirectToAction("Index");
    }

  }
}