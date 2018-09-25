using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuckProj
{
    class Program
    {
        static void Main(string[] args)
        {
             IFlyBehavior fly = new FlyWithWings();
             IFlyBehavior noFly = new NoWayFly();

             IQuackBehavior quag = new Quack();
             IQuackBehavior noQuag = new NoQuack();

            DecoyDuck dd = new DecoyDuck();
            dd.setFly(noFly);
            dd.setQuack(noQuag);

            dd.Display();
            dd.performFly();
            dd.performQuack();

            RubberDuck rd = new RubberDuck();
            rd.setFly(noFly);
            rd.setQuack(quag);

            rd.Display();
            rd.performFly();
            rd.performQuack();

            MallardDuck md = new MallardDuck();
            md.setFly(fly);
            md.setQuack(quag);

            md.Display();
            md.performFly();
            md.performQuack();
            

            Console.ReadLine();
        }
    }
}
