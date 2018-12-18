using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractPizzaFactory
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string item)
        {

            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
            if (item == "cheese")
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.SetName("Сырная пицца в НьюЙоркском стиле");
            }
            else if (item == "veggie")
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.SetName("Вегетарианская пицца в НьюЙоркском стиле");
            }
            else if (item == "clame")
            {
                pizza = new ClamePizza(ingredientFactory);
                pizza.SetName("Морская пицца в НьюЙоркском стиле");
            }
            else if (item == "pepperoni")
            {
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.SetName("Пепперони пицца в НьюЙоркском стиле");
            }
            return pizza;
        }
    }
}
