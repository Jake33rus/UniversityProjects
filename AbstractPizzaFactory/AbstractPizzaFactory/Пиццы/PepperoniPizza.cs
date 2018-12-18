using System;
namespace AbstractPizzaFactory
{
    internal class PepperoniPizza : Pizza
    {
        private IPizzaIngredientFactory ingredientFactory;

        public PepperoniPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Готовим " + GetName());
            dough = ingredientFactory.CreateDough();
            souce = ingredientFactory.CreateSouce();
            cheese = ingredientFactory.CreateCheese();
            pepperoni = ingredientFactory.CreatePepperoni();
        }
    }
}