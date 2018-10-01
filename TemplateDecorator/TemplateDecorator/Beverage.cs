using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDecorator
{
    public abstract class Beverage
    {
        public string description = "название напитка";
        public string getDescription()
        { return description; }
        public abstract double cost();
    }
}
