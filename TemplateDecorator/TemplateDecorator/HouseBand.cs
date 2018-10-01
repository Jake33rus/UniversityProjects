using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDecorator
{
    public class HouseBand : Beverage
    {
        public HouseBand()
        {
            description = "Домашний кофе";
        }

        public override double cost()
        { return 16.2; }
    }
}
