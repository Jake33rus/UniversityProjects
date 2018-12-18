using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaStore
{
    public abstract class Pizza
    {
        protected String name;
        protected String dough;
        protected String souce;
        protected String[] toppings;
        public void prepare()
        {
            Console.WriteLine("Готовим {0}", name);
            Console.WriteLine("Раскатываем {0}", dough);
            Console.WriteLine("Добавляем соус {0}", souce);
            Console.Write("Добавляем начинку:");
            foreach (String t in toppings)
            {
                Console.Write(" {0}",t);
            }
        }
        public void bake()
        {
            Console.WriteLine("\nЗапекаем 25 минут при 200 градусах");
        }
        public void cut()
        {
            Console.WriteLine("Нарезаем пиццу");
        }
        public void box()
        {
            Console.WriteLine("Кладем в фирменную коробку Pizza Store");
        }
        public String getName()
        { return name; }
    }
}
