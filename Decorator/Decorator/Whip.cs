﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class Whip : CondimentDecorator
    {
        Beverage beverage;
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }


        public override string getDescription()
        { return beverage.getDescription() + " с пенкой"; }


        public override double cost()
        { return 4.8 + beverage.cost(); }
    } 
}
