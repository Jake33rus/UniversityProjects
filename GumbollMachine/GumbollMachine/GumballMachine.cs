using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumbollMachine
{
    public class GumballMachine
    {
        IState soldOutState;
        IState noQuaterState;
        IState hasQuaterState;
        IState soldState;
        IState winnerState;
        IState state;
        int count = 0;
        public GumballMachine(int numGumballs)
        {
            soldOutState = new SoldOutState(this);
            noQuaterState = new NoQuarterState(this);
            hasQuaterState = new HasQuaterState(this);
            soldState = new SoldState(this);
            winnerState = new WinnerState(this);
            this.count = numGumballs;
            if (numGumballs > 0)
                state = noQuaterState;
            else
                state = soldOutState;
        }

        public IState GetHasQuarterState()
        { return hasQuaterState; }
        public IState GetNoQuaterState()
        { return noQuaterState; }
        public IState GetSoldState()
        { return soldState; }
        public IState GetSoldOutState()
        { return soldOutState; }
        public IState GetWinnerState()
        { return winnerState; }
        public void InsertQuarter()
        { state.InsertQuarter(); }

        public void TurnCrank()
        {
            state.TurnCrank();
            state.Dispense();
        }
        public void SetState(IState state)
        {
            this.state = state;
        }
        public void ReleasBall()
        {
            Console.WriteLine("Шарик движется к выходу");
            if (count != 0)
                count = count - 1;
        }
        public int GetCount() { return count; }
        
        public string ToString()
        {
            if (GetCount() == 0)
                return "В автомате нет шариков, ждем загрузки =)!";
            else
                return "Автомат с жвачкой работает, в нем " + GetCount() + " шариков."; 
        }

        public void Refill(int i)
        {
            count = i;
            Console.WriteLine("Добавленно {0} шариков", i);
            this.state = noQuaterState;
        }
    }
}
