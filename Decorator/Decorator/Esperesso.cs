using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class Esperesso : Beverage
    {
        public Esperesso()
        {
        }

        public override string getDescription()
        {
            return "Еспрессо";
        }
        public override double cost()
        { return 14.5; }
    }
}
