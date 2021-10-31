using System;

namespace WeatherTracker
{
    /// <summary>
    /// Describes weather tracker data.
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    public class TrackerDataEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackerDataEventArgs"/> class with tracker's data.
        /// </summary>
        /// <param name="temperature">The temperature.</param>
        /// <param name="humidity">The humidity.</param>
        /// <param name="pressure">The pressure.</param>
        /// <exception cref="System.ArgumentException">
        /// Humidity can not be less than 0 or more than 100. - humidity
        /// or
        /// Pressure can not be less than zero. - pressure
        /// </exception>
        public TrackerDataEventArgs(int temperature, int humidity, int pressure)
        {
            if (humidity < 0 || humidity > 100)
            {
                throw new ArgumentException("Humidity can not be less than 0 or more than 100.", nameof(humidity));
            }

            if (pressure < 0)
            {
                throw new ArgumentException("Pressure can not be less than zero.", nameof(pressure));
            }

            this.Temperature = temperature;
            this.Humidity = humidity;
            this.Pressure = pressure;
        }

        /// <summary>
        /// Gets the temperature.
        /// </summary>
        /// <value>
        /// The temperature.
        /// </value>
        public int Temperature { get; }

        /// <summary>
        /// Gets the humidity.
        /// </summary>
        /// <value>
        /// The humidity.
        /// </value>
        public int Humidity { get; }

        /// <summary>
        /// Gets the pressure.
        /// </summary>
        /// <value>
        /// The pressure.
        /// </value>
        public int Pressure { get; }
    }
}
