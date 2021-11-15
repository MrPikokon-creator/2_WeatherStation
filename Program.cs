using System;
using WeatherStation.Publisher;
using WeatherStation.Subscriber;

namespace WeatherStation
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            IPublisher publisher = new WeatherData();
            
            publisher.AddSubscriber(new CurrentDisplay());
            publisher.AddSubscriber(new StatisticsDisplay());
            publisher.NotifySubscribers();
        }
    }
}