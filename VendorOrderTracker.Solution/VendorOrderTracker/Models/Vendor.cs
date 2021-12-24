using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};

    public string Name {get; set;}
    public string Description {get; set;}
    public List<Order> Orders {get; set;}

    public int Id {get;}

    public Vendor(string name, string description)
    {
      Name = name;
      _instances.Add(this);
      Description = description;
      Id = _instances.Count;
      Orders = new List<Order>{};
    }
    public static List<Vendor> GetAll()
    {
      return _instances;
    }
    public static Vendor Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}