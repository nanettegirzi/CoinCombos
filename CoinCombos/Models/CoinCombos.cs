using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace CoinCombo
{
  public class Coins
  {

    public string MakeChange (int total)
      {
          string output = "";
          int quarters = total / 25;
          total = total % 25;
          int dimes = total / 10;
          total = total % 10;
          int nickel = total / 5;
          total = total % 5;
          int pennies = total;
          if (quarters == 1)
          {
            output += "1 Quarter";
          } else if (quarters > 1)
          {
            output += quarters.ToString();
            output += " Quarters";
          }
          if (dimes == 1)
          {
            if(output != "")
            {
              output +=", ";
            }
            output += "1 Dime";
          } else if (dimes > 1)
          {
            if(output != "")
            {
              output +=", ";
            }
            output += dimes.ToString();
            output += " Dimes";
          }
          if (nickel == 1)
          {
            if(output != "")
            {
              output +=", ";
            }
            output += "1 Nickel";
          }
          if (pennies == 1)
          {
            if(output != "")
            {
              output +=", ";
            }
            output += "1 Penny";
          } else if (pennies > 1)
          {
            if(output != "")
            {
              output +=", ";
            }
            output += pennies.ToString();
            output += " Pennies";
          }
          return output;
      }
  }

}
