namespace WeatherStation.Subscriber
{
    public interface ISubscriber
    {
        public void Update(double temperature, byte humidity, ushort pressure);
    }
}