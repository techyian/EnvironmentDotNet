namespace EnvironmentDotNet.IoT.Sensors.BME680.DataStructures
{
    public class GasSett
    {
        public int NbConv { get; set; }
        public int HeatrCtrl { get; set; }
        public int RunGas { get; set; }
        public int HeatrTemp { get; set; }
        public int HeatrDur { get; set; }

        public GasSett(int nbConv, int heatrCtrl, int runGas, int heatrTemp, int heatrDur)
        {
            this.NbConv = nbConv;
            this.HeatrCtrl = heatrCtrl;
            this.RunGas = runGas;
            this.HeatrTemp = heatrTemp;
            this.HeatrDur = heatrDur;
        }
    }
}