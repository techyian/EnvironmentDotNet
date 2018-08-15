namespace EnvironmentDotNet.IoT.Sensors.BME680.DataStructures
{
    public class TphSett
    {
        public int OsHum { get; set; }
        public int OsTemp { get; set; }
        public int OsPres { get; set; }
        public int Filter { get; set; }

        public TphSett(int osHum, int osTemp, int osPres, int filter)
        {
            this.OsHum = osHum;
            this.OsTemp = osTemp;
            this.OsPres = osPres;
            this.Filter = filter;
        }
    }
}