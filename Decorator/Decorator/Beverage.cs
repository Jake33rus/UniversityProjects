using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public abstract class Beverage 
   {
        public virtual string getDescription()
        { return "название кофе"; }
         public abstract double cost(); 
    } 

}
