using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Sender_GRBL
{
    public class Rectangle : Geometric
    {
        public decimal Width { get; set; }
        public decimal Length { get; set; }

        public Point A
        {
            get
            {
                return new Point(Start.X, Start.Y + Length, Start.Z);
            }
        }

        public Point B
        {
            get
            {
                return new Point(Start.X + Width, Start.Y + Length, Start.Z);
            }
        }

        public Point C
        {
            get
            {
                return new Point(Start.X + Width, Start.Y, Start.Z);
            }
        }
    }

    //public decimal Length { get; set; }


    //A = X Y+l Z F
    //B = X+w Y+l Z F
    //C = X+w Y Z F
    //D = X Y Z F

}
