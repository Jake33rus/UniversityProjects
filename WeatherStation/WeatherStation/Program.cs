using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            WheatherData weatherData = new WheatherData();
            CorrentConditousDisplay currentDisplay = new CorrentConditousDisplay(weatherData);
            StatistiosDisplay statistiosDisplay = new StatistiosDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            weatherData.setMeasurements(27, 64, 224f);
            weatherData.setMeasurements(23, 18, 225f);
            weatherData.setMeasurements(15, 45, 178f);
            weatherData.removeObserver(statistiosDisplay);
            weatherData.setMeasurements(28, 13, 195f);
        }
    }
}
