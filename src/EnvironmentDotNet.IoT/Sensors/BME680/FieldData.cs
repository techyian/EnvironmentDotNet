using System;
using System.Collections.Generic;
using System.Text;

namespace EnvironmentDotNet.IoT.Sensors.BME680
{
    public struct FieldData
    {
        private int _status;
        private int _gasIndex;
        private int _measIndex;

        public int Status => _status;
        public int GasIndex => _gasIndex;
        public int MeasIndex => _measIndex;

        public FieldData(int status, int gasIndex, int measIndex)
        {
            _status = status;
            _gasIndex = gasIndex;
            _measIndex = measIndex;
        }
    }
}
