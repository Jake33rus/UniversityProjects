using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractPizzaFactory
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string item)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngridientFactory();
            if (item == "cheese")
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.SetName("Сырная пицца в Чикагском стиле");
            }
            else if (item == "veggie")
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.SetName("Вегетарианская пицца в Чикагском стиле");
            }
            else if (item == "clame")
            {
                pizza = new ClamePizza(ingredientFactory);
                pizza.SetName("Морская пицца в Чикагском стиле");
            }
            else if (item == "pepperoni")
            {
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.SetName("Пепперони пицца в Чикагском стиле");
            }
            return pizza;
        }
    }
}
