using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherStation
{
    class CorrentConditousDisplay : IObserver, IDisplayElement
    {
        private float temp;
        private float hum;
        private float press;
        private ISubject weatherData;
        public CorrentConditousDisplay(ISubject wD)
        {
            this.weatherData = wD;
            this.weatherData.registerObserver(this);
        }
        public void update(float temp, float hum, float press)
        {
            this.temp = temp;
            this.hum = hum;
            this.press = press;
            display();
        }

        public void display()
        {
            System.Console.WriteLine("Погодные условия\n температура - {0}, влажность - {1}, давление - {2}", temp, hum, press);
        }
    }
}
