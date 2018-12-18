using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumbollMachine
{
    public class NoQuarterState : IState
    {
        GumballMachine gumballMachine;
        public NoQuarterState(GumballMachine gumballMachine)
        { this.gumballMachine = gumballMachine; }
        public void Dispense()
        {
            Console.WriteLine("Сначала надо заплатить");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Монета не брошена!");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Монета брошена");
            gumballMachine.SetState(gumballMachine.GetHasQuarterState());
        }

        public void TurnCrank()
        {
            Console.WriteLine("Рычаг дернут, но монет нет!");
        }
    }
}
