using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests 
  {
    

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("title", "description", "price", "date");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "Sugar Donut.";

      Order newOrder = new Order(title, "description", "price", "date");
      string result = newOrder.Title;

      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      string title = "Sugar Donut";
      Order newOrder = new Order(title, "description", "price", "date");
      string updatedTitle = "Updated Donut";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;

      Assert.AreEqual(updatedTitle, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Sugar Donut.";

      Order newOrder = new Order("title", description, "price", "date");
      string result = newOrder.Description;

      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "Sugar Donut";
      Order newOrder = new Order("title", description, "price", "date");
      string updatedDescription = "Updated Donut";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;

      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_String()
    {
      string price = "1";

      Order newOrder = new Order("title", "description", price, "date");
      string result = newOrder.Price;

      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void SetPrice_SetsPrice_String()
    {
      string price = "1";
      Order newOrder = new Order("title", "description", price, "date");
      string updatedPrice = "2";
      newOrder.Price = updatedPrice;
      string result = newOrder.Price;

      Assert.AreEqual(updatedPrice, result);
    }

    [TestMethod]
    public void GetDate_ReturnsDate_String()
    {
      string date = "May";

      Order newOrder = new Order("title", "description", "price", date);
      string result = newOrder.Date;

      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void SetDate_SetsDate_String()
    {
      string date = "May";
      Order newOrder = new Order("title", "description", "price", date);
      string updatedDate = "June";
      newOrder.Date = updatedDate;
      string result = newOrder.Date;

      Assert.AreEqual(updatedDate, result);
    }
  }
}