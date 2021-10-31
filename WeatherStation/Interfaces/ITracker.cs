using System;

namespace WeatherStation.Interfaces
{
    /// <summary>
    /// Tracker that keeps track of the current weather information.
    /// </summary>
    public interface ITracker
    {
        /// <summary>
        /// Occurs when weather changed.
        /// </summary>
        event EventHandler<ITrackerDataEventArgs> WeatherChange;
    }
}
