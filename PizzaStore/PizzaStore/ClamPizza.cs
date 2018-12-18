using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaStore
{
    class ClamPizza : Pizza
    {
        public ClamPizza()
        {
            name = "Греческая пицца";
            dough = "тонкое тесто";
            souce = "1000 островов";
            toppings = new String[6];
            toppings[0] = "Куриная грудка";
            toppings[1] = "Помидоры";
            toppings[2] = "Сладкий перец";
            toppings[3] = "Брынза";
            toppings[4] = "Листья салата";
            toppings[5] = "Оливки";
        }
    }
}
