using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int InputNum { get; set; }
    public int UnitCost { get; set; }
    
    public Bread(int userInput)
    {
        InputNum = userInput;
        UnitCost = 5;
    }

    public int CalculateBreadCost(int BreadAmt)
    {
        int discount = BreadAmt / 3;
        int totalCost = (BreadAmt - discount) * UnitCost;
        return totalCost;
    }
  }
}