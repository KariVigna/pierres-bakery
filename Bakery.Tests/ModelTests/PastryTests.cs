using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]

  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    {
        Pastry newPastry = new Pastry(3);
        Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void CalculatePastryCostWithDiscount_ReturnsBreadCost_Int()
    {
        Pastry newPastry = new Pastry(4);
        Assert.AreEqual(newPastry.CalculatePastryCost(4), 6);
    }

        [TestMethod]
    public void CalculatePastryCostWithoutDiscount_ReturnsBreadCost_Int()
    {
        Pastry newPastry = new Pastry(1);
        Assert.AreEqual(newPastry.CalculatePastryCost(1), 2);
    }
  }
}