using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractPizzaFactory
{
    class CheesePizza : Pizza
    {
        IPizzaIngredientFactory ingredientFactory;
        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        { this.ingredientFactory = ingredientFactory; }
        public override void Prepare()
        {
            Console.WriteLine("Готовим " + GetName());
            dough = ingredientFactory.CreateDough();
            souce = ingredientFactory.CreateSouce();
            cheese = ingredientFactory.CreateCheese();
        }
    }
}
