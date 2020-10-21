using System;
namespace ENT_Sender_GRBL.CustomExceptions
{
    public class CircleException : Exception
    {
        public CircleException()
        {
        }

        public CircleException(double cX, double cY, double r)
            :base($"The Radius value {r} must be greater than Center X {cX} and Y {cY}")
        {

        }
    }
}