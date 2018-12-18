namespace AbstractPizzaFactory
{
    internal class Pepperoni : IPepperoni
    {
        public Pepperoni()
        {
            System.Console.WriteLine("Добавляем пепперони");
        }
    }
}