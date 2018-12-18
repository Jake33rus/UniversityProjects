using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class ChocolateBoiler
    {
        public bool Empty { get; private set; }
        public bool Boiled { get; private set; }

        private static object syncRoot = new Object();
        private static ChocolateBoiler uniqueInstance;

        protected ChocolateBoiler()
        {
            Empty = true;
            Boiled = false;
        }
        public static ChocolateBoiler GetInstance()
        {
            if (uniqueInstance == null)
            {
                lock (syncRoot)
                {
                    if(uniqueInstance == null)
                        uniqueInstance = new ChocolateBoiler();
                }
            }
            return uniqueInstance;
        }
        public bool IsEmpty()
        {
            return Empty;
        }
        public void Fill()
        {
            if(IsEmpty())
            {
                Empty = false;
                Boiled = false;
            }
        }
    }
}
