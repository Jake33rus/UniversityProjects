using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDecorator
{
    public class Esperesso : Beverage
    {
        public Esperesso()
        {
            description = "Эспрессо";
        }
 
        public override double cost()
        { return 14.5; }
    }
}
