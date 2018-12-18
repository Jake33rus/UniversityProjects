using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumbollMachine
{
    public class SoldState : IState
    {
        GumballMachine gumballMachine;
        public SoldState(GumballMachine gumballMachine)
        { this.gumballMachine = gumballMachine; }
        public void Dispense()
        {
            Console.WriteLine("Выдать шарик");
            gumballMachine.ReleasBall();
            if (gumballMachine.GetCount() > 0)
                gumballMachine.SetState(gumballMachine.GetNoQuaterState());
            else
                gumballMachine.SetState(gumballMachine.GetSoldOutState());
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Шарик уже продан, монету вернуть нельзя");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Монета уже брошена");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Рычаг уже дернут");
        }
    }
}
