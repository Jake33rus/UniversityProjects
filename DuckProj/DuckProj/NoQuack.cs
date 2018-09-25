using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuckProj
{
    class NoQuack:IQuackBehavior
    {
        public NoQuack() { }
        public void quack()
        {
            Console.WriteLine("*");
        }
    }
}
