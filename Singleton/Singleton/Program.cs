using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler boiler1;
            ChocolateBoiler boiler2;
            (new Thread(() =>
            {
                boiler1 = ChocolateBoiler.GetInstance();
            })).Start();

            boiler2 = ChocolateBoiler.GetInstance();
        }
    }
}
