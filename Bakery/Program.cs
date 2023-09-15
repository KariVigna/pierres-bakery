using System.Collections.Generic;
using System;
// using Bread.Models;
// using Pastry.Models;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery! Our fresh made bread is $5 per loaf and if you buy 2, the 3rd will be free! How many loaves of bread would you like?");
      int breadAmt = Console.ReadLine();
      Bread newBread = new Bread(breadAmt);
      Console.WriteLine("Lovely! Our pastries are $2 each and when you buy 3, the 4th will be free! How many pastries would you like?")
      int pastryAmt = Console.ReadLine();
      Pastry newPastry = new Pastry(pastryAmt);
      Console.WriteLine("Yummy! Your total will be ${Pastry.CalculatePastryCost()} ")
    }
  }
}