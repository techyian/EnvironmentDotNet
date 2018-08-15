namespace EnvironmentDotNet.IoT.Sensors.BME680.DataStructures
{
    public class Dev
    {
        public int ChipId { get; set; }
        public int DevId { get; set; }
        public BME680Intf Intf { get; set; }
        public int MemPage { get; set; }
        public int AmbTemp { get; set; }
        public CalibData Calib { get; set; }
        public TphSett TphSett { get; set; }
        public GasSett GasSett { get; set; }
        public int PowerMode { get; set; }
        public int NewFields { get; set; }
        public int InfoMsg { get; set; }
        public int ComRslt { get; set; }

        public Dev(int chipId, int devId, BME680Intf intf, int memPage,
            int ambTemp, CalibData calib, TphSett tphSett, GasSett gasSett,
            int powerMode, int newFields, int infoMsg, int comRslt)
        {
            this.ChipId = chipId;
            this.DevId = devId;
            this.Intf = intf;
            this.MemPage = memPage;
            this.AmbTemp = ambTemp;
            this.Calib = calib;
            this.TphSett = tphSett;
            this.GasSett = gasSett;
            this.PowerMode = powerMode;
            this.NewFields = newFields;
            this.InfoMsg = infoMsg;
            this.ComRslt = comRslt;
        }
    }
}