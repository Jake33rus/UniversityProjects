using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class Decaf : Beverage 
    { 
          public Decaf() 
          { 
          }  

          public override string getDescription()
          {
              return "Кофе без кофеина";
          }
          public override double cost() 
          { return 9.9; } 
    } 
}
