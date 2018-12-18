using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class DarkRost : Beverage
    {
        public DarkRost() { }
         public override string getDescription()
          {
              return "Кофе темной обжарки";
          }
        public override double cost()
        { return 18.6; }

    }
}