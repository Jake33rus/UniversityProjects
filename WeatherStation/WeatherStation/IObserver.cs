using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherStation
{
    interface IObserver
    {
       void update(float temp, float hum, float press);
    }
}
