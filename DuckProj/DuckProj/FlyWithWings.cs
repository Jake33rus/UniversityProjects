using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuckProj
{
    class FlyWithWings : IFlyBehavior
    {
        public FlyWithWings() { }
        public void fly()
        {
            Console.WriteLine("Yeah, i can fly!");
        }
    }
}
