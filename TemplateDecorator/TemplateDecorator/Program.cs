using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Esperesso();
            beverage = new Mocha(beverage);
            Console.WriteLine(beverage.getDescription() + ", " + beverage.cost() + "руб.");
            Beverage bev2 = new DarkRost();
            bev2 = new Mocha(bev2);
            bev2 = new Mocha(bev2);
            bev2 = new Whip(bev2);
            Console.WriteLine(bev2.getDescription() + ", " + bev2.cost() + "руб.");
        }
    }
}
