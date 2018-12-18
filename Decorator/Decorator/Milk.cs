using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class Milk : CondimentDecorator
    {
        Beverage beverage;
        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }


        public override string getDescription()
        { return this.beverage.getDescription() + " c молоком"; }


        public override double cost()
        { return 2.3 + beverage.cost(); }
    } 
}
