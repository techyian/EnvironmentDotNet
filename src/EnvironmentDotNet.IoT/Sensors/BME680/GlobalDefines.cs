using System;
using System.Collections.Generic;
using System.Text;

namespace EnvironmentDotNet.IoT.Sensors.BME680
{
    public static class GlobalDefines
    {
        public const int BME680PollPeriodMs = 10;

        // I2C addresses
        public const int BME680I2CAddrPrimary = 0x76;
        public const int BME680I2CAddrSecondary = 0x77;

        // Unique chip identifier
        public const int BME680ChipId = 0x61;

        // BME680 coefficient defines
        public const int BME680CoeffSize = 41;
        public const int BME680CoeffAddr1Len = 25;
        public const int BME680CoeffAddr2Len = 16;

        // Field_x related defines
        public const int BME680FieldLength = 15;
        public const int BME680FieldAddrOffset = 17;

        public const int BME680SoftResetCmd = 0xb6;

        // Error code definitions
        public const int BME680Ok = 0;

        // Errors
        public const int BME680ENullPtr = -1;
        public const int BME680EComFail = -2;
        public const int BME680EDevNotFound = -3;
        public const int BME680EInvalidLength = -4;

        // Warnings
        public const int BME680WDefinePwrMode = 1;
        public const int BME680WNoNewData = 2;

        // Info's
        public const int BME680IMinCorrection = 1;
        public const int BME680IMaxCorrection = 2;

        // Other coefficient addresses
        public const int BME680AddrResHeatValAddr = 0x00;
        public const int BME680AddrResHeatRangeAddr = 0x02;
        public const int BME680AddrRangeSwErrAddr = 0x04;
        public const int BME680AddrSensConfStart = 0x5a;
        public const int BME680AddrGasConfStart = 0x64;

        // Field settings
        public const int BME680Field0Addr = 0x1d;

        // Heater settings
        public const int BME680ResHeat0Addr = 0x5a;
        public const int BME680GasWait0Addr = 0x64;

        // Sensor configuration registers
        public const int BME680ConfHeatCtrlAddr = 0x70;
        public const int BME680ConfOdrRunGasNbcAddr = 0x71;
        public const int BME680ConfOsHAddr = 0x72;
        public const int BME680MemPageAddr = 0xf3;
        public const int BME680ConfTPModeAddr = 0x74;
        public const int BME680ConfOdrFiltAddr = 0x75;

        // Coefficient addresses
        public const int BME680CoeffAddr1 = 0x89;
        public const int BME680CoeffAddr2 = 0xe1;

        // Chip identifier
        public const int BME680ChipIdAddr = 0xd0;

        // Soft reset register
        public const int BME680SoftResetAddr = 0xe0;

        // Heater control settings
        public const int BME680EnableHeater = 0x00;
        public const int BME680DisableHeater = 0x08;

        // Gas measurement settings
        public const int BME680DisableGasMeas = 0x00;
        public const int BME680EnableGasMeas = 0x01;

        // Delay related macro declaration
        public const int BME680ResetPeriod = 10;

        // SPI memory page settings
        public const int BME680MemPage0 = 0x10;
        public const int BME680MemPage1 = 0x00;

        // Ambient humidity shift value for compensation
        public const int BME680HumRegShiftVal = 4;

        // Run gas enable and disable settings
        public const int BME680RunGasDisable = 0;
        public const int BME680RunGasEnable = 1;

        // Number of conversion settings
        public const int BME680NbConvMin = 0;
        public const int BME680NbConvMax = 10;

        // Pressure calculation
        public const int BME680MaxOverflow = 0x40000000;
    }

    public enum BME680RegisterBufferIndex
    {
        Filter = 5,
        Temp = 4,
        Pres = 4,
        Hum = 2,
        NBConv = 1,
        RunGas = 1,
        HCTRL = 0
    }

    public enum BME680IndexToFieldMapping
    {
        T2LSB = 1,
        T2MSB = 2,
        T3 = 3,
        P1LSB = 5,
        P1MSB = 6,
        P2LSB = 7,
        P2MSB = 8,
        P3 = 9,
        P4LSB = 11,
        P4MSB = 12,
        P5LSB = 13,
        P5MSB = 14,
        P7 = 15,
        P6 = 16,
        P8LSB = 19,
        P8MSB = 20,
        P9LSB = 21,
        P9MSB = 22,
        P10 = 23,
        H2MSB = 25,
        H2LSB = 26,
        H1LSB = 26,
        H1MSB = 27,
        H3 = 28,
        H4 = 29,
        H5 = 30,
        H6 = 31,
        H7 = 32,
        T1LSB = 33,
        T1MSB = 34,
        GH2LSB = 35,
        GH2MSB = 36,
        GH1 = 37,
        GH3 = 38
    }

    public enum BME680Mask
    {
        GasMeas = 0x30,
        NbConv = 0x0F,
        Filter = 0x1C,
        OST = 0xE0,
        OSP = 0x1C,
        OSH = 0x07,
        HCtrl = 0x08,
        RunGas = 0x10,
        Mode = 0x03,
        RHRange = 0x30,
        RSError = 0xf0,
        NewData = 0x80,
        GasIndex = 0x0f,
        GasRange = 0x0f,
        GasMValid = 0x20,
        HeatStab = 0x10,
        MemPage = 0x10,
        SpiRd = 0x80,
        SpiWr = 0x7f,
        BitH1Data = 0x0F
    }

    public enum BME680Position
    {
        GasMeas = 4,
        Filter = 2,
        OST = 5,
        OSP = 2,
        RunGas = 4
    }

    public enum BME680BufferLength
    {
        Tmp = 40,
        Reg = 6,
        Field = 3,
        Gas = 20
    }

    public enum BME680SettingsSelector
    {
        OST = 1,
        OSP = 2,
        OSH = 4,
        GasMeas = 8,
        Filter = 16,
        HCntrl = 32,
        RunGas = 64,
        NbConv = 128,
        GasSensor = (BME680SettingsSelector.GasMeas | BME680SettingsSelector.RunGas | BME680SettingsSelector.NbConv)
    }

    public enum BME680OverSampling
    {
        OSNone,
        OS1X,
        OS2X,
        OS4X,
        OS8X,
        OS16X
    }

    public enum BME680IIRFilter
    {
        Size0,
        Size1,
        Size3,
        Size7,
        Size15,
        Size31,
        Size63,
        Size127
    }

    public enum BME680PowerMode
    {
        Sleep,
        Forced
    }
}
