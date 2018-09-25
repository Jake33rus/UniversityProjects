using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherStation
{
    class ForecastDisplay : IObserver, IDisplayElement
    {
        private float temp = 0;
        private float hum = 0;
        private float press = 0;
        private ISubject weatherData;

        public ForecastDisplay(ISubject wD)
        {
            this.weatherData = wD;
            this.weatherData.registerObserver(this);
        }

        public void update(float temp, float hum, float press)
        {
            this.temp += temp - this.temp;
            this.hum += hum - this.hum;
            this.press += press - this.press;
            display();
        }

        public void display()
        {
            System.Console.WriteLine("Прогноз погоды на завтра\n температура - {0} влажность - {1} давление - {2}", temp, hum, press);
        }
    }
}
