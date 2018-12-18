namespace AbstractPizzaFactory
{
    internal class VeryThinDough : IDough
    {
        public VeryThinDough()
        {
            System.Console.WriteLine("Добавляем очень тонкую основу");
        }
    }
}