using System;
using WeatherStation.Interfaces;

namespace WeatherStation
{
    /// <summary>
    /// Weather station that monitors current weather conditions.
    /// </summary>
    public class Station
    {
        private readonly ITracker tracker;

        /// <summary>
        /// Initializes a new instance of the <see cref="Station"/> class.
        /// </summary>
        /// <param name="tracker">The tracker.</param>
        /// <exception cref="System.ArgumentNullException">tracker - Tracker can not be null.</exception>
        public Station(ITracker tracker)
        {
            if (tracker is null)
            {
                throw new ArgumentNullException(nameof(tracker), "Tracker can not be null.");
            }

            this.tracker = tracker;
            this.tracker.WeatherChange += OnWeatherChange;
        }

        /// <summary>
        /// Occurs when weather change.
        /// </summary>
        public event EventHandler<ITrackerDataEventArgs> WeatherChange = delegate { };

        private void OnWeatherChange(object sender, ITrackerDataEventArgs trackerData)
        {
            this.WeatherChange?.Invoke(this, trackerData);
        }
    }
}
