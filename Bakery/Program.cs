using System.Collections.Generic;
using System;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      Console.BackgroundColor = ConsoleColor.Blue;
      Console.WriteLine("Welcome to Pierre's Bakery! Our fresh made bread is $5 per loaf and if you buy 2, the 3rd will be free! How many loaves of bread would you like?");
      int breadAmt = int.Parse(Console.ReadLine());
      Bread newBread = new Bread(breadAmt);
      Console.WriteLine("Lovely! Our pastries are $2 each and when you buy 3, the 4th will be free! How many pastries would you like?");
      int pastryAmt = int.Parse(Console.ReadLine());
      Pastry newPastry = new Pastry(pastryAmt);
      Console.WriteLine("Yummy! You ordered " + breadAmt.ToString() + " loafs of bread and " + pastryAmt.ToString() + " pastries!");
      Console.WriteLine("Your total will be $" + newBread.CalculateBreadCost(breadAmt) + newPastry.CalculatePastryCost(pastryAmt));
    }
  }
}