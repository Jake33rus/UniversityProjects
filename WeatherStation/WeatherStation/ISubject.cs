using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherStation
{
    interface ISubject
    {
       void registerObserver(IObserver o);
       void removeObserver(IObserver o);
       void notifyObserver();
    }
}
