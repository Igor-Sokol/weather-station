using Moq;
using NUnit.Framework;
using System;
using WeatherStation;
using WeatherStation.Interfaces;
using WeatherTracker;

namespace WeatherStationTests
{
    class StationMoq
    {
        [Test]
        public void EventMethodsCallCheck()
        {
            var tracker = new Tracker();
            var trackerAdapter = new TrackerAdapter(tracker);
            
            Station station = new Station(trackerAdapter);

            var trackerData = new Mock<EventHandler<ITrackerDataEventArgs>>();
            station.WeatherChange += trackerData.Object;

            tracker.RandomUpdateWeather();
            tracker.RandomUpdateWeather();
            tracker.RandomUpdateWeather();
            tracker.RandomUpdateWeather();
            tracker.RandomUpdateWeather();

            trackerData.Verify(n => n(It.IsAny<object>(), It.IsAny<ITrackerDataEventArgs>()), Times.Exactly(5));
        }

        [Test]
        public void EventMethodsNotCallCheck()
        {
            var tracker = new Tracker();
            var trackerAdapter = new TrackerAdapter(tracker);

            Station station = new Station(trackerAdapter);

            var trackerData = new Mock<EventHandler<ITrackerDataEventArgs>>();
            station.WeatherChange += trackerData.Object;

            trackerData.Verify(n => n(It.IsAny<object>(), It.IsAny<ITrackerDataEventArgs>()), Times.Never);
        }
    }
}
