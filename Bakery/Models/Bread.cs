using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int InputNum { get; set; }
    public int UnitCost { get; set; }
    // public int TotalCost { get; set; }
    
    public Bread(int userInput)
    {
        InputNum = userInput;
        UnitCost = 5;
    }

    public int CalculateBreadCost(int BreadAmt)
    {
        // Bread newBread = new Bread(int userInput);
        int discount = BreadAmt / 3;
        int totalCost = (BreadAmt - discount) * UnitCost;
        return totalCost;
    }
  }
}

//  public int GetOrderCost(){
//       int discount = BreadQuantity /3;
//       int totalCost = (BreadQuantity - discount) * UnitCost;
//        TotalCost = totalCost
//       return totalCost;
//     }


//psuedoProgram.cs

// Bread newBread = new Bread(3);
// newBread.GetOrderCost();

// newBread.TotalCost
//"your total is ${newBread.TotalCost + newPastry.TotalCost}"