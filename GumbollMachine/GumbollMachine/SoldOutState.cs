using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumbollMachine
{
    public class SoldOutState : IState
    {
        GumballMachine gumballMachine;
        
        public SoldOutState (GumballMachine gumballMachine)
        { this.gumballMachine = gumballMachine; }
        
        public void Dispense()
        {
            Console.WriteLine("Шарики закончились =(");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Шарики закончились =(");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Шарики закончились =(");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Шарики закончились =(");
        }
    }
}
