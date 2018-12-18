using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractPizzaFactory
{
    class ChicagoPizzaIngridientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new ChedrCheese();
        }

        public IClam CreateClam()
        {
            return new FrozenClam();
        }

        public IDough CreateDough()
        {
            return new VeryThinDough();
        }

        public IPepperoni CreatePepperoni()
        {
            return new SpicyPepperoni();
        }

        public ISouce CreateSouce()
        {
            return new SweetChili();
        }

        public List<IVeggies> CreateVeggies()
        {
            List<IVeggies> veggies = new List<IVeggies>();
            veggies.Add(new GreenOnion());
            veggies.Add(new Cherry());
            veggies.Add(new Basil());
            veggies.Add(new SaltedCucumbers());
            veggies.Add(new Corn());
            return veggies;
        }
    }
}
