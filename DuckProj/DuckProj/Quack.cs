using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuckProj
{
    class Quack:IQuackBehavior
    {
        public Quack() { }
        public void quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
