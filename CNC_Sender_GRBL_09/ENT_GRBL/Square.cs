using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Sender_GRBL
{
    public class Square : Geometric
    {
        public double Side { get; set; }

        public Point A { get
            {
                return new Point(Start.X, Start.Y + Side, Start.Z);
            }
        }

        public Point B
        {
            get
            {
                return new Point(Start.X + Side, Start.Y + Side, Start.Z);
            }
        }

        public Point C
        {
            get
            {
                return new Point(Start.X + Side, Start.Y, Start.Z);
            }
        }
        
        //A = X Y+l Z F
        //B = X+l Y+l Z F
        //C = X+l Y Z F
        //D = X Y Z F
    }
}
