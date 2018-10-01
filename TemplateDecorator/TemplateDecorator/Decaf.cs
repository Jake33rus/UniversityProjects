using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDecorator
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Кофе без кофеина";
        }

        public override double cost()
        { return 9.9; }
    }
}

