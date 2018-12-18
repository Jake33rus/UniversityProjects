using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractPizzaFactory
{
    public interface IPizzaIngredientFactory
    {
         IDough CreateDough();
         ISouce CreateSouce();
         ICheese CreateCheese();
         List<IVeggies> CreateVeggies();
         IPepperoni CreatePepperoni();
         IClam CreateClam();
    }
}
