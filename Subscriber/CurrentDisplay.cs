using System;

namespace WeatherStation.Subscriber
{
    public class CurrentDisplay : ISubscriber
    {
        public void Update(double temperature, byte humidity, ushort pressure)
        {
            Console.WriteLine("Текущий дисплей");
            Console.WriteLine($"Температура: {temperature}");
            Console.WriteLine($"Влажность: {humidity}");
            Console.WriteLine($"Давление: {pressure}\n");
        }
    }
}