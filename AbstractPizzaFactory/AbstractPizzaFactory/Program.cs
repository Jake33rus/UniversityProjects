using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractPizzaFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            NYPizzaStore store = new NYPizzaStore();
            Pizza pizza = store.CreatePizza("cheese");
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            Console.WriteLine();
            pizza = store.CreatePizza("veggie");
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            Console.WriteLine();
            pizza = store.CreatePizza("clame");
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            Console.WriteLine();
            pizza = store.CreatePizza("pepperoni");
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }
    }
}
