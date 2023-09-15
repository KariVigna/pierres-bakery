using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]

  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
        Bread newBread = new Bread(3);
        Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void CalculateBreadCostWithDiscount_ReturnsBreadCost_Int()
    {
        Bread newBread = new Bread(3);
        Assert.AreEqual(newBread.CalculateBreadCost(3), 10);
    }

        [TestMethod]
    public void CalculateBreadCostWithoutDiscount_ReturnsBreadCost_Int()
    {
        Bread newBread = new Bread(1);
        Assert.AreEqual(newBread.CalculateBreadCost(1), 5);
    }
  }
}