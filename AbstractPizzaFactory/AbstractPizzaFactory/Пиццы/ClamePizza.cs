using System;
namespace AbstractPizzaFactory
{
    internal class ClamePizza : Pizza
    {
        private IPizzaIngredientFactory ingredientFactory;

        public ClamePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Готовим " + GetName());
            dough = ingredientFactory.CreateDough();
            souce = ingredientFactory.CreateSouce();
            clam = ingredientFactory.CreateClam();
        }
    }
}