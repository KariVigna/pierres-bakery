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
    public void GetInputNum_ReturnsUserChoice_Int()
    {
        int userInput = 3;
        Bread newBread = new Bread(userInput);
        Assert.AreEqual(newBread.InputNum, userInput);

    }
  }
}