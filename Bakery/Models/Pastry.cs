using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int InputNum { get; set; }
    public int UnitCost { get; set; }
    
  
    public Pastry(int userInput)
    {
        InputNum = userInput;
        UnitCost = 2;
    }

    public int CalculatePastryCost(int PastryAmt)
    {
        int discount = PastryAmt / 4;
        int totalCost = (PastryAmt - discount) * UnitCost;
        return totalCost;
    }
  }
}