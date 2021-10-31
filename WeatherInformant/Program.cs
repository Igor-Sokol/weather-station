using WeatherStation;
using WeatherTracker;

namespace WeatherInformant
{
    class Program
    {
        static void Main(string[] args)
        {
            Tracker tracker = new Tracker();
            Station station = new Station(new TrackerAdapter(tracker));

            OnlineWeather onlineWeather = new OnlineWeather();
            station.WeatherChange += onlineWeather.CurrentConditionsReport;

            tracker.RandomUpdateWeather();
            tracker.RandomUpdateWeather();
            tracker.RandomUpdateWeather();
            tracker.RandomUpdateWeather();
        }
    }
}
