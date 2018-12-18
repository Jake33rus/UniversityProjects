using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaStore
{
    class PepperoniPizza : Pizza
    {
        public PepperoniPizza()
        {
            name = "Пепперони пицца";
            dough = "тонкое тесто";
            souce = "кетчуп";
            toppings = new String[4];
            toppings[0] = "Колбаска";
            toppings[1] = "Помидоры";
            toppings[2] = "Сладкий перец";
            toppings[3] = "Моццарела";
        }
    }
}
