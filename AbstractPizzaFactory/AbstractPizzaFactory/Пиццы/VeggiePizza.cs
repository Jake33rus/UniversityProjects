using System;
namespace AbstractPizzaFactory
{
    internal class VeggiePizza : Pizza
    {
        private IPizzaIngredientFactory ingredientFactory;

        public VeggiePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Готовим " + GetName());
            dough = ingredientFactory.CreateDough();
            souce = ingredientFactory.CreateSouce();
            cheese = ingredientFactory.CreateCheese();
            veggies = ingredientFactory.CreateVeggies();
        }
    }
}