using System;
using WeatherStation.Interfaces;
using WeatherTracker;

namespace WeatherStation
{
    /// <inheritdoc/>
    internal class TrackerDataAdapterEventArgs : EventArgs, ITrackerDataEventArgs
    {
        private readonly TrackerDataEventArgs trackerData;

        public TrackerDataAdapterEventArgs(TrackerDataEventArgs trackerData)
        {
            this.trackerData = trackerData;
        }

        /// <inheritdoc/>
        public int Temperature => trackerData.Temperature;

        /// <inheritdoc/>
        public int Humidity => trackerData.Humidity;

        /// <inheritdoc/>
        public int Pressure => trackerData.Pressure;
    }
}
