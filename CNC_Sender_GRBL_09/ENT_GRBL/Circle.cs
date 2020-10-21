using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT_Sender_GRBL.CustomExceptions;

namespace ENT_Sender_GRBL
{
    public class Circle : Geometric
    {

        public Circle(double cX, double cY, double r, double feed)
        {
            if (!ValidateParameters(cX, cY, r))
                throw new CircleException(cX, cY, r);

            Feed = feed;
            Center = new Point(cX, cY, 0);
            Radio = r;
        }

        public Point Center { get; set; }
        public double Radio { get; set; }

        public override Point Start
        {
            get
            {
                return new Point(Center.X - Radio, Center.Y, Center.Z);
            }
        }

        public Point End
        {
            get
            {
                return Start;
            }
        }

        public double IG2 {
            get
            {
                return Center.X - Radio;
            }
        }

        public double IG3
        {
            get
            {
                return Center.X + Radio;
            }
        }

        private bool ValidateParameters(double cX, double cY, double r)
        {
            return ((r <= cX) && (r <= cY));
        }
    }
}
