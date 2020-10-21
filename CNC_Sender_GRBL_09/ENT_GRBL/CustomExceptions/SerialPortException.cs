using System;
namespace ENT_Sender_GRBL.CustomExceptions
{
    public class SerialPortException : Exception
    {
        public SerialPortException(string message) : base(message)
        {
        }
    }
}