using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractPizzaFactory
{
    class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public IClam CreateClam()
        {
            return new Clam();
        }

        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public IPepperoni CreatePepperoni()
        {
            return new Pepperoni();
        }

        public ISouce CreateSouce()
        {
            return new MarianaraSouce();
        }

        public List<IVeggies> CreateVeggies()
        {
            List<IVeggies> veggies = new List<IVeggies>();
            veggies.Add(new Garlic());
            veggies.Add(new Onion());
            veggies.Add(new RedPepper());
            veggies.Add(new Mashroom());
            return veggies;
        }
    }
}
