using System;
using System.Collections.Generic;
using System.Linq;

namespace WeatherStation.Subscriber
{
    public class StatisticsDisplay : ISubscriber
    {
        HashSet<double> temperaturesList = new HashSet<double>() { 12.4, 14.5, 13.8, 19.2, 17.4 };
        HashSet<byte> humiditiesList = new HashSet<byte>() { 32, 34, 39, 42, 37 };
        HashSet<ushort> pressuresList = new HashSet<ushort>() { 754, 759, 753, 749, 756 };
        
        public void Update(double temperature, byte humidity, ushort pressure)
        {
            temperaturesList.Add(temperature);
            humiditiesList.Add(humidity);
            pressuresList.Add(pressure);
            
            double temperaturesAverage = Math.Round(temperaturesList.Average(), 1);
            double humiditiesAverage = Math.Round(humiditiesList.Average(x => x), 1);
            double pressuresAverage = Math.Round(pressuresList.Average(x => x), 1);
            
            Console.WriteLine("Статистический дисплей");
            Console.WriteLine($"Средняя температура: {temperaturesAverage}");
            Console.WriteLine($"Средняя влажность: {humiditiesAverage}");
            Console.WriteLine($"Среднее давление: {pressuresAverage}\n");
        }
    }
}