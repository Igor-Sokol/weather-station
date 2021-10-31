using NUnit.Framework;
using WeatherStation;
using WeatherStation.Interfaces;
using WeatherTracker;

namespace WeatherStationTests
{
    public class Tests
    {
        [TestCase(5)]
        [TestCase(15)]
        [TestCase(0)]
        [TestCase(1)]
        public void StationTests(int count)
        {
            var tracker = new Tracker();
            var station = new Station(new TrackerAdapter(tracker));

            

            int i = 0;
            void EventCall(object sender, ITrackerDataEventArgs trackerData)
            {
                i++;
                Assert.AreEqual(tracker.Temperature, tracker.Temperature);
                Assert.AreEqual(tracker.Humidity, tracker.Humidity);
                Assert.AreEqual(tracker.Pressure, tracker.Pressure);
            }

            station.WeatherChange += EventCall;

            for (int j = 0; j < count; j++)
            {
                tracker.RandomUpdateWeather();
            }

            Assert.AreEqual(count, i);
        }
    }
}
