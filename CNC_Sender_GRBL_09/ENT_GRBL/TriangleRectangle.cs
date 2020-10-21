using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Sender_GRBL
{
    public class TriangleRectangle : Geometric
    {
        public double LengthSide { get; set; }
        public double HeigthSide { get; set; }

        public Point A
        {
            get
            {
                return new Point(Start.X + LengthSide, Start.Y, Start.Z);
            }
        }


        public Point B
        {
            get
            {
                return new Point(Start.X + LengthSide, Start.Y + HeigthSide, Start.Z);
            }
        }
    }
}
