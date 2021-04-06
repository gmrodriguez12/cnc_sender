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



    }
}
