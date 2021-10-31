using System;

namespace WeatherTracker
{
    /// <summary>
    /// Tracker that keeps track of the current weather information.
    /// </summary>
    public class Tracker
    {
        /// <summary>
        /// Occurs when weather changed.
        /// </summary>
        public event EventHandler<TrackerDataEventArgs> WeatherChange = delegate { };

        /// <summary>
        /// Gets the temperature.
        /// </summary>
        /// <value>
        /// The temperature.
        /// </value>
        public int Temperature { get; private set; }

        /// <summary>
        /// Gets the humidity.
        /// </summary>
        /// <value>
        /// The humidity.
        /// </value>
        public int Humidity { get; private set; }

        /// <summary>
        /// Gets the pressure.
        /// </summary>
        /// <value>
        /// The pressure.
        /// </value>
        public int Pressure { get; private set; }

        /// <summary>
        /// Randoms the update weather (Only for staging).
        /// </summary>
        public void RandomUpdateWeather()
        {
            var random = new Random();

            this.Temperature = random.Next(-30, 30);
            this.Humidity = random.Next(0, 101);
            this.Pressure = random.Next(400, 900);

            OnWeatherChange(new TrackerDataEventArgs(this.Temperature, this.Humidity, this.Pressure));
        }

        private void OnWeatherChange(TrackerDataEventArgs trackerData)
        {
            this.WeatherChange?.Invoke(this, trackerData);
        }
    }
}
