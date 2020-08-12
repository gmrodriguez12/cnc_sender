using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Sender_GRBL
{
    public class Point
    {
        public Point()
        {

        }

        public Point(decimal x, decimal y, decimal z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public decimal X { get; set; }
        public decimal Y { get; set; }
        public decimal Z { get; set; }
    }
}
