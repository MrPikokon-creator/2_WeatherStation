using System;
using System.Collections.Generic;
using WeatherStation.Subscriber;

namespace WeatherStation.Publisher
{
    public class WeatherData : IPublisher
    {
        private List<ISubscriber> subscribers = new List<ISubscriber>();
        private Random random = new Random();
        
        // Добавление подписчика
        public void AddSubscriber(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        // Удаление пиодписчика
        public void DeleteSubscriber(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }
        
        // Уведомление всем подписчикам
        public void NotifySubscribers()
        {
            foreach (ISubscriber subscriber in subscribers)
            {
                double temperature = GetTemperature();
                byte humidity = GetHumidity();
                ushort pressure = GetPressure();
                
                subscriber.Update(temperature, humidity, pressure);
            }
        }
        
        // Получение температуры
        public double GetTemperature()
        {
            return (double)random.Next(0, 300) / 10;
        }
        
        // Получение влажности
        public byte GetHumidity()
        {
            return (byte)random.Next(0, 100);
        }
        
        // Получение давления
        public ushort GetPressure()
        {
            return (ushort)random.Next(720, 800);
        }
    }
}