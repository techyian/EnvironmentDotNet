namespace EnvironmentDotNet.IoT.Sensors.BME680.DataStructures
{
    public class CalibData
    {
        public int ParH1 { get; set; }

        public int ParH2 { get; set; }

        public int ParH3 { get; set; }

        public int ParH4 { get; set; }

        public int ParH5 { get; set; }

        public int ParH6 { get; set; }

        public int ParH7 { get; set; }

        public int ParGH1 { get; set; }

        public int ParGH2 { get; set; }

        public int ParGH3 { get; set; }

        public int ParT1 { get; set; }

        public int ParT2 { get; set; }

        public int ParT3 { get; set; }

        public int ParP1 { get; set; }

        public int ParP2 { get; set; }

        public int ParP3 { get; set; }

        public int ParP4 { get; set; }

        public int ParP5 { get; set; }

        public int ParP6 { get; set; }

        public int ParP7 { get; set; }

        public int ParP8 { get; set; }

        public int ParP9 { get; set; }

        public int ParP10 { get; set; }

        public float TFine { get; set; }

        public int ResHeatRange { get; set; }
        
        public int ResHeatVal { get; set; }
        
        public int RangeSwErr { get; set; }

        public CalibData(int parh1, int parh2, int parh3, int parh4,
            int parh5, int parh6, int parh7, int pargh1, int pargh2,
            int pargh3, int part1, int part2, int part3, int parp1,
            int parp2, int parp3, int parp4, int parp5, int parp6,
            int parp7, int parp8, int parp9, int parp10, float tfine,
            int resHeatRange, int resHeatVal, int rangeSwErr)
        {
            this.ParH1 = parh1;
            this.ParH2 = parh2;
            this.ParH3 = parh3;
            this.ParH4 = parh4;
            this.ParH5 = parh5;
            this.ParH6 = parh6;
            this.ParH7 = parh7;
            this.ParGH1 = pargh1;
            this.ParGH2 = pargh2;
            this.ParGH3 = pargh3;
            this.ParT1 = part1;
            this.ParT2 = part2;
            this.ParT3 = part3;
            this.ParP1 = parp1;
            this.ParP2 = parp2;
            this.ParP3 = parp3;
            this.ParP4 = parp4;
            this.ParP5 = parp5;
            this.ParP6 = parp6;
            this.ParP7 = parp7;
            this.ParP8 = parp8;
            this.ParP9 = parp9;
            this.ParP10 = parp10;
            this.TFine = tfine;
            this.ResHeatRange = resHeatRange;
            this.ResHeatVal = resHeatVal;
            this.RangeSwErr = rangeSwErr;
            
        }
    
}
}