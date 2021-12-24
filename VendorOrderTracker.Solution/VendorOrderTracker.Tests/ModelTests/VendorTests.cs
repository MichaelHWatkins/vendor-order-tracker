using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("name", "description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "jim";

      Vendor newVendor = new Vendor(name, "description");
      string result = newVendor.Name;

      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void SetName_SetsName_String()
    {
      string name = "jim";
      Vendor newVendor = new Vendor(name, "description");
      string updatedName = "Updated jim";
      newVendor.Name = updatedName;
      string result = newVendor.Name;

      Assert.AreEqual(updatedName, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Jim's description.";

      Vendor newVendor = new Vendor("title", description);
      string result = newVendor.Description;

      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "Jim's Description";
      Vendor newVendor = new Vendor("title", description);
      string updatedDescription = "Updated Desciption";
      newVendor.Description = updatedDescription;
      string result = newVendor.Description;

      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      
      Vendor newVendor1 = new Vendor("name01", "description1");
      Vendor newVendor2 = new Vendor("name02", "description2");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      Vendor newVendor1 = new Vendor("name01", "description1");
      Vendor newVendor2 = new Vendor("name02", "description2");

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AddsOrderToOrderList_Vendor()
    {
      Order newOrder = new Order("titel", "description", "price", "date");
      Vendor newVendor1 = new Vendor("name01", "description1");
      newVendor1.AddOrder(newOrder);
      Order result = newVendor1.Orders[0];
      Assert.AreEqual(newOrder, result);
    }
  }
}