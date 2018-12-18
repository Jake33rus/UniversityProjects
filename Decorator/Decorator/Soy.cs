using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class Soy : CondimentDecorator
    {
        Beverage beverage;
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }


        public override string getDescription()
        { return beverage.getDescription() + " с соевым молоком"; }


        public override double cost()
        { return 9.1 + beverage.cost(); }
    } 
}
