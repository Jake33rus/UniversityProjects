using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDecorator
{
    public class DarkRost : Beverage
    {
        public DarkRost()
        {
            description = "Кофе темной обжарки";
        }

        public override double cost()
        { return 18.6; }
    }
}
