using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaStore
{
    class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            name = "Сырная пицца";
            dough = "тонкое тесто";
            souce = "сырный";
            toppings = new String[4];
            toppings[0] = "Масдам";
            toppings[1] = "Чедр";
            toppings[2] = "Гуада";
            toppings[3] = "Моццарела";
        }
    }
}
