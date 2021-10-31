using System;
using WeatherStation.Interfaces;
using WeatherTracker;

namespace WeatherStation
{
    /// <inheritdoc/>
    internal class TrackerAdapter : ITracker
    {
        internal Tracker tracker;

        public TrackerAdapter(Tracker tracker)
        {
            this.tracker = tracker;
            this.tracker.WeatherChange += OnWeatherChange;
        }

        /// <inheritdoc/>
        public event EventHandler<ITrackerDataEventArgs> WeatherChange;

        private void OnWeatherChange(object sender, TrackerDataEventArgs trackerData)
        {
            this.WeatherChange?.Invoke(sender, new TrackerDataAdapterEventArgs(trackerData));
        }
    }
}
