using NUnit.Framework;
using WeatherTracker;

namespace WeatherTrackerTests
{
    public class Tests
    {
        [TestCase(5)]
        [TestCase(15)]
        [TestCase(0)]
        [TestCase(1)]
        public void TrackerTests(int count)
        {
            var tracker = new Tracker();

            int i = 0;
            void EventCall(object sender, TrackerDataEventArgs trackerData)
            {
                i++;
                Assert.AreEqual(tracker.Temperature, tracker.Temperature);
                Assert.AreEqual(tracker.Humidity, tracker.Humidity);
                Assert.AreEqual(tracker.Pressure, tracker.Pressure);
            }

            tracker.WeatherChange += EventCall;

            for (int j = 0; j < count; j++)
            {
                tracker.RandomUpdateWeather();
            }

            Assert.AreEqual(count, i);
        }
    }
}