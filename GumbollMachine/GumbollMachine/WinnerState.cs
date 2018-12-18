using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumbollMachine
{
    public class WinnerState : IState
    {
        GumballMachine gumballMachine;
        public WinnerState(GumballMachine gumballMachine)
        { this.gumballMachine = gumballMachine; }
        public void Dispense()
        {
            Console.WriteLine("Приз!!!");
            gumballMachine.ReleasBall();
            if (gumballMachine.GetCount() == 0)
                gumballMachine.SetState(gumballMachine.GetSoldOutState());
            else
            {
                gumballMachine.ReleasBall();
                if (gumballMachine.GetCount() > 0)
                    gumballMachine.SetState(gumballMachine.GetNoQuaterState());
                else
                {
                    Console.WriteLine("Шарики закончились =(");
                    gumballMachine.SetState(gumballMachine.GetSoldOutState());
                }
            }
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Вы уже повернули рычаг, подождите");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Подожди, шарик уже выдается");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Вы уже повернули рычаг");
        }
    }
}
