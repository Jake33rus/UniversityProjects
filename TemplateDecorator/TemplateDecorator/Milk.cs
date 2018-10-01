using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDecorator
{
   class Milk : CondimentDecorator
    {
        Beverage beverage;
        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        { return beverage.getDescription() + " с молоком"; }

        public override double cost()
        { return 2.3 + beverage.cost(); }
    }
}
