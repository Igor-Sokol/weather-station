using System;
using WeatherStation.Interfaces;

namespace WeatherInformant
{
    /// <summary>
    /// Live weather broadcast.
    /// </summary>
    public class OnlineWeather
    {
        private (int previousTemperature, int previousHumidity, int previousPressure) previousInformation;
        private (int temperature, int humidity, int pressure) information;

        /// <summary>
        /// Get previous data.
        /// </summary>
        public void StatisticReport()
        {
            Console.WriteLine("Previous data - Temperature: " + previousInformation.previousTemperature +
                " Humidity: " + previousInformation.previousHumidity + 
                " Pressure: " + previousInformation.previousPressure);
            Console.WriteLine();
        }

        /// <summary>
        /// Currents the conditions report.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="trackerData">The <see cref="ITrackerDataEventArgs"/> instance containing the event data.</param>
        public void CurrentConditionsReport(object sender, ITrackerDataEventArgs trackerData)
        {
            Console.WriteLine("Current data - Temperature: " + trackerData.Temperature + " Humidity: " + trackerData.Humidity + " Pressure: " + trackerData.Pressure);
            this.previousInformation = this.information;
            this.information = (trackerData.Temperature, trackerData.Humidity, trackerData.Pressure);
            this.StatisticReport();
        }
    }
}
