using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaStore
{
    public class SimplePizzaFactory
    {
        public Pizza createPizza(String type)
        {
            Pizza pizza = null;
            if (type == "cheese")
                pizza = new CheesePizza();
            else if (type == "peperoni")
                pizza = new PepperoniPizza();
            else if (type == "clam")
                pizza = new ClamPizza();
            return pizza;
        }
    }
}
