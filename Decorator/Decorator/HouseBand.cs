using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class HouseBand : Beverage
    {
        public HouseBand()
        {
        }
        public override string getDescription()
        {
            return "Домашний кофе";
        }

        public override double cost()
        { return 16.2; }
    } 
}
