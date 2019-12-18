using System;
using System.Collections.Generic;

namespace Coins.Models
{
  public class Change
  {
    public double Total { get; set; }
    public double HalfDollar { get; private set; }
    public double Quarter { get; private set; }
    public double Dime { get; private set; }
    public double Nickle { get; private set; }
    public double Penny { get; private set; }
    public Change(int change)
    {
      Total = (double)change;
      HalfDollar = 50;
      Quarter = 25;
      Dime = 10;
      Nickle = 5;
      Penny = 1;
    }

    public string ReturnChange()
    {
      
    }
  }
}