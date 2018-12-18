using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumbollMachine
{
    public class HasQuaterState : IState
    {
        GumballMachine gumballMachine;
        Random randomWinner = new Random(System.DateTime.Now.Millisecond);
        public HasQuaterState(GumballMachine gumballMachine)
        { this.gumballMachine = gumballMachine; }
        public void Dispense()
        {
            Console.WriteLine("Жвачка не выдана");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Вернуть монету");
            gumballMachine.SetState(gumballMachine.GetNoQuaterState());
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Монета уже брошена!");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Рычаг дернут");
            int winner = randomWinner.Next(10);
            if ((winner == 0) && (gumballMachine.GetCount() > 1))
                gumballMachine.SetState(gumballMachine.GetWinnerState());
            else
                gumballMachine.SetState(gumballMachine.GetSoldState());
        }
    }
}
