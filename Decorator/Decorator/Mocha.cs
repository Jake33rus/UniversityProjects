using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class Mocha : CondimentDecorator
    {
        Beverage beverage;
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        { return beverage.getDescription() + " с шоколадом"; }


        public override double cost()
        { return 5.7 + beverage.cost(); }
    }
}
