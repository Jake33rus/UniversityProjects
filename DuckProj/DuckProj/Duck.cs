using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuckProj
{
    class Duck
    {
        private IFlyBehavior flyBehavior;
        private IQuackBehavior quackBehavior;

        public Duck() { }

        public void Swim()
        { 
            Console.WriteLine("Eee boi!");
        }
        public virtual void Display()
        { }

        public void performFly()
        { 
            this.flyBehavior.fly();
        }
        public void performQuack()
        { 
            this.quackBehavior.quack();
        }

        public void setFly(IFlyBehavior fb)
        { 
            flyBehavior = fb;
        }
        public void setQuack(IQuackBehavior qb)
        { 
            quackBehavior = qb;
        }
    }
}
