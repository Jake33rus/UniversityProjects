namespace AbstractPizzaFactory
{
    internal class ThinCrustDough : IDough
    {
        public ThinCrustDough()
        {
            System.Console.WriteLine("Добавляем тонкую хрустящую основу");
        }
    }
}