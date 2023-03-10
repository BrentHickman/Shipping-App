using System.Collections.Generic;
using System;


namespace ShippingApp.Models
{
  public class Parcel
  {
    public string Description { get; set; }

    public int Length { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public int Volume { get; }
    public double ShipCost { get; }


    private static List<Parcel> _instances = new List<Parcel> { };

    public Parcel(string description, int length, int width, int height, int weight)
    {
      Description = description;
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;
      Volume = this.SetVolume();
      ShipCost = this.SetShipCost();
      _instances.Add(this);
    }

    public static List<Parcel> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static void ShipParcel(string aParcel)
    { 
      foreach(Parcel parcelToShip in _instances)
      {
        Console.WriteLine("Comparing " + parcelToShip.Description + " to " + aParcel);
        if(parcelToShip.Description.Equals(aParcel))
        {
          _instances.RemoveAt(_instances.IndexOf(parcelToShip));
          return;
        }
      }
      Console.WriteLine(_instances);
    }

    public int SetVolume()
    {
      int volume = Length * Width * Height;
      return volume;
    }

    public double SetShipCost()
    {
      double shipCost = ((Volume * Weight) * 0.25);
      return shipCost;
    }
  }
}
