using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherStation
{
    class WheatherData : ISubject
    {
        private List<IObserver> observers;
        private float temp;
        private float hum;
        private float press;

        public WheatherData()
        {
            observers = new List<IObserver>();
        }

        public void registerObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void removeObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void notifyObserver()
        {
            foreach (IObserver o in observers)
            { o.update(temp, hum, press); }
        }

        public void measurementsChange()
        {
            notifyObserver();
        }

        public void setMeasurements(float temp, float hum, float press)
        {
            this.temp = temp;
            this.hum = hum;
            this.press = press;
            measurementsChange();
        }
    }
}
