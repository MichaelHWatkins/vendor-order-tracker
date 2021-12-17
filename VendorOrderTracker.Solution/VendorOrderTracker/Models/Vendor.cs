using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};

    public string Name {get; set;}
    public string Description {get; set;}
    public List<Order> Orders {get; set;}

    public Vendor(string name, string description)
    {
      Name = name;
      _instances.Add(this);
      Description = description;
      Orders = new List<Order>{};
    }
    public static List<Vendor> GetAll()
    {
      return _instances;
    }
  }
}