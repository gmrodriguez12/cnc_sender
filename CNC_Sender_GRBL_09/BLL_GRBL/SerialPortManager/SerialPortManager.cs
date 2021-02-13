using System;
using System.IO.Ports;
using System.Text;
using ENT_GRBL.Config;
using ENT_Sender_GRBL.CustomExceptions;

namespace BLL_Sender_GRBL.SerialPortManager
{
    public static class SerialPortManager
    {
        public static SerialPort serial = new SerialPort();
        public static string Properties { get; set; }

        public static StringBuilder PortReader { get; set; }
        public static Grbl09Settings Settings { get; set; }
        public static string[] ListAvailablePorts()
        {
            return SerialPort.GetPortNames();
        }

        public static void OpenConnection(string portName)
        {
            try
            {
                serial.PortName = portName;
                serial.BaudRate = 115200;
                serial.DataBits = 8;
                serial.Parity = Parity.None;
                serial.StopBits = StopBits.One;
                serial.Handshake = Handshake.None;
                serial.NewLine = "\n";
                serial.WriteTimeout = 2000;
                //serial.ReadTimeout = 2000;
                serial.DtrEnable = true;
                serial.RtsEnable = true;
                serial.DataReceived += new SerialDataReceivedEventHandler(Port_DataReceived);
                serial.Open();

                serial.DiscardOutBuffer();
                serial.DiscardInBuffer();
            }
            catch(Exception ex)
            {
                throw new SerialPortException(ex.Message);
            }
        }

        public static void CloseConnection()
        {
            if (serial.IsOpen)
                serial.Close();
            else
                throw new SerialPortException("The connection to the serial port was already closed");
        }

        public static void ExecuteCommand(string line)
        {
            if (!string.IsNullOrEmpty(line))
            {
                serial.WriteLine(line);
            }
        }

        public static void ExecuteCommands(string[] lines)
        {
            if (lines == null || lines.Length == 0)
                throw new SerialPortException("Set of gcode lines null or empty");

            foreach(string line in lines)
            {
                if(!string.IsNullOrEmpty(line))
                    serial.WriteLine(line);
            }
        }

        public static void ExecuteCommands(StringBuilder lines)
        {
            if (lines == null)
                throw new SerialPortException("Set of gcode lines null or empty");

            string[] setLines = lines.ToString().Split(Environment.NewLine.ToCharArray());

            ExecuteCommands(setLines);
        }

        public delegate void ReceiveDataFromGRBLDelegate(string data);
        public static event ReceiveDataFromGRBLDelegate ReceiveDataEvent;

        public static void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serial.ReadExisting();
            ReceiveDataEvent(data);
        }
        
        private static void ParseConfig()
        {
            Properties = Properties.Replace("\r\n", "|");
            string[] arrProps = Properties.Split('|');

            if (arrProps != null && arrProps.Length >= 29)
            {
                Settings = new Grbl09Settings();
                Settings.StepPulse = GetConfigItemValue(arrProps[(int)IndexSetting.Settings_GRBL_09.StepPulse]);
                Settings.StepIdleDelay = GetConfigItemValue(arrProps[(int)IndexSetting.Settings_GRBL_09.StepIdleDelay]);
                Settings.StepPortInvert = GetConfigItemValue(arrProps[(int)IndexSetting.Settings_GRBL_09.StepPortInvert]);

                Settings.DirPortInvert = GetConfigItemValue(arrProps[(int)IndexSetting.Settings_GRBL_09.DirPortInvert]);
                Settings.StepEnableInvert = GetConfigItemValue(arrProps[(int)IndexSetting.Settings_GRBL_09.StepEnableInvert]);
                Settings.ProbePinInvert = GetConfigItemValue(arrProps[(int)IndexSetting.Settings_GRBL_09.ProbePinInvert]);

                Settings.StatusReport = GetConfigItemValue(arrProps[(int)IndexSetting.Settings_GRBL_09.StatusReport]);
                Settings.JunctionDeviation = GetConfigItemValue(arrProps[(int)IndexSetting.Settings_GRBL_09.JunctionDeviation]);
                Settings.ArcTolerance = GetConfigItemValue(arrProps[(int)IndexSetting.Settings_GRBL_09.ArcTolerance]);
                Settings.ReportInches = GetConfigItemValue(arrProps[(int)IndexSetting.Settings_GRBL_09.ReportInches]);

                Settings.SoftLimits = GetConfigItemValue(arrProps[(int)IndexSetting.Settings_GRBL_09.SoftLimits]);
                Settings.HardLimits = GetConfigItemValue(arrProps[(int)IndexSetting.Settings_GRBL_09.HardLimits]);

                Settings.HomingCycle = GetConfigItemValue(arrProps[(int)IndexSetting.Settings_GRBL_09.HomingCycle]);
                Settings.HomingDirInvert = GetConfigItemValue(arrProps[(int)IndexSetting.Settings_GRBL_09.HomingDirInvert]);
                Settings.HomingFeed = GetConfigItemValue(arrProps[(int)IndexSetting.Settings_GRBL_09.HomingFeed]);
                Settings.HomingSeek = GetConfigItemValue(arrProps[(int)IndexSetting.Settings_GRBL_09.HomingSeek]);
                Settings.HomingDebounce = GetConfigItemValue(arrProps[(int)IndexSetting.Settings_GRBL_09.HomingDebounce]);
                Settings.HomingPullOff = GetConfigItemValue(arrProps[(int)IndexSetting.Settings_GRBL_09.HomingPullOff]);

                Settings.xStepBymm = GetConfigItemValue(arrProps[(int)IndexSetting.Settings_GRBL_09.xStepBymm]);
                Settings.yStepBymm = GetConfigItemValue(arrProps[(int)IndexSetting.Settings_GRBL_09.yStepBymm]);
                Settings.zStepBymm = GetConfigItemValue(arrProps[(int)IndexSetting.Settings_GRBL_09.zStepBymm]);

                Settings.xMaxRate = GetConfigItemValue(arrProps[(int)IndexSetting.Settings_GRBL_09.xMaxRate]);
                Settings.yMaxRate = GetConfigItemValue(arrProps[(int)IndexSetting.Settings_GRBL_09.yMaxRate]);
                Settings.zMaxRate = GetConfigItemValue(arrProps[(int)IndexSetting.Settings_GRBL_09.zMaxRate]);

                Settings.xAcceleration = GetConfigItemValue(arrProps[(int)IndexSetting.Settings_GRBL_09.xAcceleration]);
                Settings.yAcceleration = GetConfigItemValue(arrProps[(int)IndexSetting.Settings_GRBL_09.yAcceleration]);
                Settings.zAcceleration = GetConfigItemValue(arrProps[(int)IndexSetting.Settings_GRBL_09.zAcceleration]);

                Settings.xMaxTravel = GetConfigItemValue(arrProps[(int)IndexSetting.Settings_GRBL_09.xMaxTravel]);
                Settings.yMaxTravel = GetConfigItemValue(arrProps[(int)IndexSetting.Settings_GRBL_09.yMaxTravel]);
                Settings.zMaxTravel = GetConfigItemValue(arrProps[(int)IndexSetting.Settings_GRBL_09.zMaxTravel]);
            }
        }

        private static string GetConfigItemValue(string item)
        {
            try
            {
                return item.Split(' ')[0].Split('=')[1];
            }
            catch
            {
                return null;
            }
        }

    }
}
