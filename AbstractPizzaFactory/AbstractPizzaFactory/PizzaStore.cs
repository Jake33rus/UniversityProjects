 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractPizzaFactory
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza;
            pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Box();
            return pizza;
        }
        public abstract Pizza CreatePizza(string type);
    }
}
