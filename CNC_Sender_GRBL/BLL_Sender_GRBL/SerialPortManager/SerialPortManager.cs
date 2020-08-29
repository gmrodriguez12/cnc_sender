using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;
using ENT_Sender_GRBL.CustomExceptions;

namespace BLL_Sender_GRBL.SerialPortManager
{
    public static class SerialPortManager
    {
        public static SerialPort serial = new SerialPort();

        public static string[] ListAvailablePorts()
        {
            throw new NotImplementedException();
        }

        public static void OpenConnection(string portName)
        {
            serial.PortName = portName;
            serial.BaudRate = 115200;
            serial.DataBits = 8;
            serial.Parity = Parity.None; //?
            serial.StopBits = StopBits.One; //?
            serial.Handshake = Handshake.None; //?
            serial.NewLine = "\n";
            serial.WriteTimeout = 1000;
            serial.DtrEnable = false; //?
            serial.RtsEnable = false; //?
            serial.Open();
            serial.DiscardOutBuffer();
            serial.DiscardInBuffer();
        }

        public static void CloseConnection()
        {
            if (serial.IsOpen)
                serial.Close();
            else
                throw new SerialPortException("The connection to the serial port was already closed");
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
    }
}
