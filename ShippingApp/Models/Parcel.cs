using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Parcel
  {
    public string Description { get; set; }

    public int Length { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }


    private static List<Item> _instances = new List<Item> { };

    public Parcel(string description, int length, int width, int height, int weight)
    {
      Description = description;
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;

      _instances.Add(this);
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
