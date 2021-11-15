using WeatherStation.Subscriber;

namespace WeatherStation.Publisher
{
    public interface IPublisher
    {
        public void AddSubscriber(ISubscriber subscriber);
        public void DeleteSubscriber(ISubscriber subscriber);
        public void NotifySubscribers();
    }
}