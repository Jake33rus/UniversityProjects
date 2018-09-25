using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuckProj
{
    class NoWayFly:IFlyBehavior
    {
        public NoWayFly() { }
        public void fly()
        {
            Console.WriteLine("Oh no, i cant fly!");
        }
    }
}
