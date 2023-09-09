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
    public void GetInputNum_ReturnsUserChoice_Int()
    {
        int userInput = 3;
        Pastry newPastry = new Pastry(userInput);
        Assert.AreEqual(newPastry.InputNum, userInput);
    }

    [TestMethod]
    public void SetInputNum_ReturnsUserChoice_Int()
    {
        int userInput = 3;
        Pastry newPastry = new Pastry(userInput);
        int userInput2 = 5;
        newPastry.InputNum = userInput2;
        Assert.AreEqual(newPastry.InputNum, userInput2);
    }
  }
}