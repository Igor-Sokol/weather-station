using System;

namespace WeatherStation.Interfaces
{
    /// <summary>
    /// Describes tracker data.
    /// </summary>
    public interface ITrackerDataEventArgs
    {
        /// <summary>
        /// Gets the temperature.
        /// </summary>
        /// <value>
        /// The temperature.
        /// </value>
        int Temperature { get; }

        /// <summary>
        /// Gets the humidity.
        /// </summary>
        /// <value>
        /// The humidity.
        /// </value>
        int Humidity { get; }

        /// <summary>
        /// Gets the pressure.
        /// </summary>
        /// <value>
        /// The pressure.
        /// </value>
        int Pressure { get; }
    }
}
