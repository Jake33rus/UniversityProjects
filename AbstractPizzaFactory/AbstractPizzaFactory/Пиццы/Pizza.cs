using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractPizzaFactory
{
    public abstract class Pizza
    {
        private string name;
        protected IDough dough;
        protected ISouce souce;
        protected List<IVeggies> veggies;
        protected ICheese cheese;
        protected IPepperoni pepperoni;
        protected IClam clam;

        public abstract void Prepare();
        public void Bake()
        { Console.WriteLine("Готовим 25 мин при 350 С"); }
        public void Cut()
        { Console.WriteLine("Режем"); }
        public void Box()
        { Console.WriteLine("Упакуем"); }
        public void SetName(string name)
        { this.name = name; }
        public string GetName()
        { return name; }
        public string toString()
        { return ""; }
    }
}
