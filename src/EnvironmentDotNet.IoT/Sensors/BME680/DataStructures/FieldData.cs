using System;
using System.Collections.Generic;
using System.Text;

namespace EnvironmentDotNet.IoT.Sensors.BME680.DataStructures
{
    public class FieldData
    {
        /// <summary>
        /// Contains new_data, gasm_valid & heat_stab.
        /// </summary>
        public int Status { get; set;}

        /// <summary>
        /// The index of the heater profile used.
        /// </summary>
        public int GasIndex { get; set;}

        /// <summary>
        /// Measurement index to track order.
        /// </summary>
        public int MeasIndex { get; set;}

        /// <summary>
        /// Temperature in degree celsius.
        /// </summary>
        public float Temperature { get; set;}

        /// <summary>
        /// Pressure in Pascal.
        /// </summary>
        public float Pressure { get; set;}

        /// <summary>
        /// Humidity in % relative humidity x1000.
        /// </summary>
        public float Humidity { get; set;}

        /// <summary>
        /// Gas resistance in 0hms.
        /// </summary>
        public float GasResistance { get; set;}

        public FieldData(int status, int gasIndex, int measIndex, float temperature,
                         float pressure, float humidity, float gasResistance)
        {
            Status = status;
            GasIndex = gasIndex;
            MeasIndex = measIndex;
            Temperature = temperature;
            Pressure = pressure;
            Humidity = humidity;
            GasResistance = gasResistance;
        }
    }
}
