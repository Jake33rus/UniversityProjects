using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherStation
{
    class StatistiosDisplay: IObserver, IDisplayElement
    {
        private float temp = 0;
        private float hum = 0;
        private float press = 0;
        private int i = 1;
        private ISubject weatherData;

        public StatistiosDisplay(ISubject wD)
        {
            this.weatherData = wD;
            this.weatherData.registerObserver(this);
        }
        public void update(float temp, float hum, float press)
        {
            this.temp += temp;
            this.hum += hum;
            this.press += press;
            display();
            i++;
        }

        public void display()
        {
            System.Console.WriteLine("Средняя сатистика погодных условий на {0}-ый день\n температура - {1}, влажность - {2}, давление - {3}", i, temp / i, hum / i, press / i);
        }
    }
}
