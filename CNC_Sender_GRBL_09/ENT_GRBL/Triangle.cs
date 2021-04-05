using ENT_Sender_GRBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_GRBL
{
    public class Triangle : Geometric
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Point A
        {
            get
            {
                return new Point(Start.X + Base, Start.Y, Start.Z);
            }
        }

        public Point B
        {
            get
            {
                return new Point((Start.X + Base) / 2, Start.Y + Height, Start.Z);
            }
        }
    }
}
